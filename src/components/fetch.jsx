import React, { useState, useEffect } from 'react';
import Cards from './Cards';

function Fetch() {
    const [selectedOption, setSelectedOption] = useState('top');
    const [data, setData] = useState([]);
    const [results, setResults] = useState([]);
    const [query, setQuery] = useState('');

    const handleChange = (event) => {
        setSelectedOption(event.target.value);
    };

    const handleSearchChange = (event) => {
      setQuery(event.target.value);
  };

    useEffect(() => {
        if (selectedOption) {
            fetch(`https://newsdata.io/api/1/latest?country=ar&language=es&category=${selectedOption}&apikey=pub_534696ba6dd08e675da4b35891446954221b0`)
                .then(response => response.json())
                .then(json => {
                    const dataNews = json.results;
                  setData(dataNews);
                })
                .catch(error => console.error(error));
        }
    }, [selectedOption]);

    useEffect(() => {
      if (query) {
      fetch(`https://newsdata.io/api/1/latest?country=ar&language=es&qInTitle=${query}&apikey=pub_534696ba6dd08e675da4b35891446954221b0`)
        .then(response => response.json())
        .then(json => {
          console.log(json);
          const dataResults = json.results;
          setResults(dataResults)
        })
        .catch(error => console.error(error));
      }
    }, [query]);

    return (
        <div>
          <div className='select-container'>  
            <label htmlFor="categories" className="block text-sm font-medium leading-6 text-gray-900">Categoria</label>
            <select
                id="categories"
                name="categories"
                autoComplete="category-name"       
                value={selectedOption}
                onChange={handleChange}
                className='select select-primary w-full max-w-xs'
            >
              <option value="">Selecciona una categoría</option>
              <option value="top">Top</option>
              <option value="business">Negocios</option>
              <option value="entertainment">Entretenimiento</option>
              <option value="health">Salud</option>
              <option value="science">Ciencia</option>
              <option value="sports">Deportes</option>
              <option value="technology">Tecnología</option>
            </select>
          </div>

          <label id="inputSearch" className="input input-bordered flex items-center gap-2">
            <input type="text" className="grow" placeholder="Search" value={query} onChange={handleSearchChange}/>
            <svg
              onClick={() => setQuery(query)}
              xmlns="http://www.w3.org/2000/svg"
              viewBox="0 0 16 16"
              fill="currentColor"
              className="h-4 w-4 opacity-70">
            <path
              fillRule="evenodd"
              d="M9.965 11.026a5 5 0 1 1 1.06-1.06l2.755 2.754a.75.75 0 1 1-1.06 1.06l-2.755-2.754ZM10.5 7a3.5 3.5 0 1 1-7 0 3.5 3.5 0 0 1 7 0Z"
              clipRule="evenodd" 
            />
            </svg>
          </label>

          <p className='text-center text-2xl md:text-3xl pl-2 my-2 border-l-4  font-sans font-bold border-teal-400  dark:text-gray-200'>Latest News: {selectedOption}</p>
            
            {/* Renderiza el componente DataDisplay y pasa los datos como props */}
            {query ? <Cards data={results} /> : <Cards data={data} />}  
        </div>
    );
}

export default Fetch;
