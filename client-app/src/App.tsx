import { useEffect, useState } from 'react';
import './App.css'
import axios from 'axios';

function App() {
  const [items, setItems] = useState([]);

  useEffect(() => {
    axios.get('http://localhost:5000/api/items')
      .then(response => {
        setItems(response.data);
      });
  }, [])

  return (
    <>
      <h1>Quartermaster</h1>
      <ul>
        {items.map((item: any) => (
          <li key={item.id}>
            {item.name}
          </li>
        ))}
      </ul>
    </>
  )
}

export default App
