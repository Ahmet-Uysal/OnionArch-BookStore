import { createSlice, PayloadAction } from "@reduxjs/toolkit";
import { v4 } from "uuid"
export interface Todo {
    id: string,
    title: string,
    complated: boolean
}

const initialState: Todo[] = []
const todoSlice = createSlice({
    name: "todos",
    initialState,
    reducers: {
        add: (state, action: PayloadAction<string>) => {
            const newTodo: Todo = {
                id: v4(),
                title: action.payload,
                complated: false
            }
            state.push(newTodo);
        }

    }
});
export default todoSlice.reducer;
export const { add } = todoSlice.actions;