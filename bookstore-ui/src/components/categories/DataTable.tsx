import * as React from 'react';
import { DataGrid, GridColDef, GridValueGetterParams } from '@mui/x-data-grid';
import { useAppDispatch, useAppSelector } from '../../store';
import { fetchCategory } from '../../features/categorySlice';
import { Button } from '@mui/material';
import { Category } from '../../interface/Category';
import { useEffect } from 'react';

const columns: GridColDef[] = [
    { field: 'id', headerName: 'ID', align: "center", headerAlign: "center" },
    { field: 'name', headerName: 'First name', align: "center", headerAlign: "center" },
    { field: 'createdDate', headerName: 'Creation Date', type: "string", align: "center", headerAlign: "center" },
    {
        field: 'modifyDate',
        headerName: 'Modify Date',
        type: 'string',
        align: "center"
        , headerAlign: "center"

    },
    {
        field: 'isActive',
        headerName: 'Active',
        align: "center"
        , headerAlign: "center",
        type: "boolean",
        resizable: true
        // valueGetter: (params: GridValueGetterParams) =>
        //     `${params.row.firstName || ''} ${params.row.lastName || ''}`,
    },
    {
        field: 'isDeleted',
        headerName: 'Deleted',
        align: "center"
        , headerAlign: "center"
        // valueGetter: (params: GridValueGetterParams) =>
        //     `${params.row.firstName || ''} ${params.row.lastName || ''}`,
    },
];


export default function DataTable() {
    const categories = useAppSelector(state => state.category)
    const dispatch = useAppDispatch();
    const getCategory = () => {
        dispatch(fetchCategory())
    }
    useEffect(() => {
        getCategory()
    }, [])
    return (
        <div style={{ height: 400, width: '100%' }}>
            <Button onClick={getCategory}>Verileri  Çek</Button>
            <DataGrid
                rows={!categories.loading ? categories.data as any : []}
                columns={columns}
                pageSize={5}
                rowsPerPageOptions={[5]}
                checkboxSelection
                loading={categories.loading}

            />
        </div>
    );
}
