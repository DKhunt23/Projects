//@author Dipsa Khunt
import * as React from "react"; 
import {BrowserRouter, Routes, Route} from 'react-router-dom';
import Home from './pages/Home';
import Inventory from './pages/Inventory';
import Search from './pages/Search';
import About from './pages/About';
import NoPage from './pages/NoPage';


export default function App(){
    return(
       <div>
        {/* path for pages */}
        <BrowserRouter>
            <Routes>
                <Route index element={<Home/>} />
                <Route path='/' element={<Home />} />
                <Route path='inventory' element={<Inventory />} />
                <Route path='search' element={<Search/>} />
                <Route path='about' element={<About/>}/>
                <Route path='*' element={<NoPage/>} />
            </Routes>
        </BrowserRouter>
       </div>
    )
}