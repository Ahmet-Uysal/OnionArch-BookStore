import { Container } from '@mui/material';
import React from 'react'
import DataTable from '../components/categories/DataTable';
import { fetchCategory } from '../features/categorySlice';
import { useAppDispatch, useAppSelector } from '../store';

function Categories() {

    return (
        <div><Container maxWidth="xl" style={{ marginTop: "5rem" }} >
            <DataTable />
        </Container></div>
    )
}

export default Categories