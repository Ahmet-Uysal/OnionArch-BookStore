import { useState } from "react";
import { fetchCategory } from "./features/categorySlice";
import { add } from "./features/todoSlice";
import { useAppDispatch, useAppSelector } from "./store";
import Button from '@mui/material/Button';
import '@fontsource/roboto/500.css';
import { Route, Routes } from "react-router-dom";
import Categories from "./pages/Categories";
import Contract from "./pages/Contract";
import Navbar from "./components/navbar/Navbar";
function App() {


  return (
    <div className="App">
      <Navbar></Navbar>
      <Routes>
        <Route path='/Contract' element={<Contract></Contract>}></Route>
        <Route path='/Categories' element={<Categories></Categories>}></Route>
      </Routes>
      {/* <input
        type="text"
        name="title"
        value={title}
        onChange={(e) => setTitle(e.currentTarget.value)} />
      <button onClick={onSave}> Kaydet </button>
      <ul>
        {todos.map(x => <li key={x.id}>{x.title}-----{x.complated ? "asda" : "asfgf"}</li>)}

      </ul>
      <div>
        <Button variant="contained" onClick={getCategory}>Verileri Çek</Button>
        <div>
          {categories.loading ? "bekliyor" : "bitti"}
        </div>
        <table>
          <thead>
            <thead style={{ marginLeft: 50 }}>Id</thead>
            <thead style={{ marginLeft: 50 }}>Name</thead>
          </thead>
          <tbody>
            {categories.data?.map(x => <tr key={x.id}><th>{x.id}</th><th>{x.name}</th></tr>)}
          </tbody>
        </table>
        <ul>

        </ul>
      </div> */}
    </div>


  );
}

export default App;
