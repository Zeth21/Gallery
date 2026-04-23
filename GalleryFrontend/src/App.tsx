import { useEffect, useState } from 'react'

function App() {
  const [data, setData] = useState<any[]>([]);

  useEffect(() => {
    fetch('https://localhost:7173/weatherforecast')
      .then(response => response.json())
      .then(json => setData(json))
      .catch(error => console.error('Hata:', error));
  }, []);

  return (
    <div style={{ padding: '20px', fontFamily: 'Arial' }}>
      <h1>Araba Galerisi - API Testi</h1>
      <h3>Backend'den Gelen Hava Durumu Verileri:</h3>
      <ul>
        {data.map((item, index) => (
          <li key={index}>
            {item.date}: <b>{item.temperatureC}°C</b> - {item.summary}
          </li>
        ))}
      </ul>
    </div>
  )
}

export default App