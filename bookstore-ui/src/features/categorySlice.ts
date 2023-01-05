import { createAsyncThunk, createSlice, PayloadAction } from "@reduxjs/toolkit";
import axios from "axios";
import { Category, CategoryState, Response } from "../interface/Category";

const initialState: CategoryState = {
    data: null,
    loading: false,
    error: ""
}

export const fetchCategory = createAsyncThunk("fetchCategory", async () => {
    const response = await axios.get<Response<Category[]>>("http://localhost:5295/api/Category/");
    return response.data.data;
})
const categorySlice = createSlice({
    name: "category",
    initialState,
    reducers: {},
    extraReducers: (builder) => {
        builder.addCase(fetchCategory.pending, (state, action) => {
            state.loading = true;
            state.error = "";
        });
        builder.addCase(fetchCategory.fulfilled, (state, action: PayloadAction<Category[]>) => {
            state.loading = false;
            state.error = "";
            state.data = action.payload;
        });
        builder.addCase(fetchCategory.rejected, (state, action) => {
            state.loading = false;
            state.error = "errors";
        });
    }
});
export default categorySlice.reducer