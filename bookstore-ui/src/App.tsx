import { useState } from "react";
import { fetchCategory } from "./features/categorySlice";
import { add } from "./features/todoSlice";
import { useAppDispatch, useAppSelector } from "./store";


function App() {
  const todos = useAppSelector(state => state.todos)
  const categories = useAppSelector(state => state.category)
  const [title, setTitle] = useState("")
  const dispatch = useAppDispatch();
  const onSave = () => {
    dispatch(add(title));
    setTitle("");
  }
  const getCategory = () => {
    dispatch(fetchCategory())
  }
  return (
    <div className="App">
      <input
        type="text"
        name="title"
        value={title}
        onChange={(e) => setTitle(e.currentTarget.value)} />
      <button onClick={onSave}> Kaydet </button>
      <ul>
        {todos.map(x => <li key={x.id}>{x.title}-----{x.complated ? "asda" : "asfgf"}</li>)}

      </ul>
      <div>
        <button onClick={getCategory}>Verileri Çek</button>
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
      </div>
    </div>


  );
}

export default App;
