import { useEffect, useState } from 'react'

export default function Theme() {
    const [theme, setTheme ] = useState('coffee')

    const handleChange = (event) => {
        setTheme(event.target.value);
    };

    useEffect(() => {

        document.body.setAttribute('data-theme', theme);

    }, [theme]);
    
    return (
        <>
          <select
            name='themes'
            onChange={handleChange} 
            value={theme}
            className="select select-primary"
          >
            <option value="dark">Dark</option>
            <option value="light">Light</option>
            <option value="coffee">Coffee</option>
          </select>
        </>
    )
}