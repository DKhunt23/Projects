//@author Dipsa Khunt
import React from 'react';
import { AppBar, Toolbar, Typography, Button } from '@mui/material';
import { NavLink,useLocation } from 'react-router-dom';


const Navbar = () => {
  const location = useLocation();

  const isActive = (path) => {
    return location.pathname === path;
  };
  return (
    // navbar
    <AppBar position="static" style={{ marginTop: '20px' ,backgroundColor: '#778899 '}}>
      <Toolbar>
        <Typography variant="h6" component="div" sx={{ flexGrow: 1 }}>
          <NavLink to="/"  style={{ textDecoration: 'none', color: 'white' }}>
          Pet Inventory
          </NavLink>
        </Typography>
        <Button  style={{ border: isActive('/') ? '2px solid white' : 'none' }}>
          <NavLink to="/"   style={{ textDecoration: 'none', color: 'white' }} >
            Home
          </NavLink>
        </Button>
        <Button style={{ border: isActive('/about') ? '2px solid white' : 'none' }}>
          <NavLink to="/about" style={{ textDecoration: 'none', color: 'white' }} >
            About
          </NavLink>
        </Button>
        <Button style={{ border: isActive('/inventory') ? '2px solid white' : 'none' }}>
          <NavLink to="/inventory" style={{ textDecoration: 'none', color: 'white' }}>
          Inventory
          </NavLink>
        </Button>

        <Button style={{ border: isActive('/search') ? '2px solid white' : 'none' }}>
          <NavLink to="/search" style={{ textDecoration: 'none', color: 'white' }}>
          Search
          </NavLink>
        </Button>
      </Toolbar>
    </AppBar>
  );
};

export default Navbar;


