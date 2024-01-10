// @author Dipsa Khunt
import Navbar from "../component/Navbar";
import React, { useState, useEffect } from 'react';
import { Typography, Table, TableBody, TableCell, TableContainer, TableHead, TableRow, Paper, Button, TextField, IconButton } from '@mui/material';

// styles for table and textfeild
const styles = {
    container: {
      display: 'flex',
      flexDirection: 'column',
      alignItems: 'center',
  
    },
    contentContainer: {
        maxWidth: '980px', 
        width: '100%',
       
      },
    tableContainer: {
      margin: '20px',
    
    },
    textField: {
      margin: '20px',
      textAlign: 'center', 

    },
    tableHeaderCell: {
        background: '#f2f2f2', 
    
      },
  };

export default function Search(){
    const [isLoaded, setIsLoaded] = useState(false);
    const [pets, setPets] = useState([]);
    const [searchResults, setSearchResults] = useState([]);
    const [searchTerm, setSearchTerm] = useState('');

    /**
     * fetch all data
     */
    function fetchPets()
    {
      fetch("http://localhost:3001/api?act=getall")
      .then(res => res.json())
      .then(
        (result) => {
          setIsLoaded(true);
          setPets(result);
        })    
    }
    useEffect(fetchPets, []);

    //setting searched keywords
    const filterPets = (term) => {
        setSearchTerm(term);
        searchPet(term);
        
      };

    /**
     * search the data based on keyword
     * @param {*} term - searched keyword
     */
    function searchPet(term)
    {
      fetch("http://localhost:3001/api?act=search&term="+term)
      .then(res => res.json())
      .then((result) => {
          setSearchResults(result);
        });
    }


    if (!isLoaded) {
      return <div>Loading...</div>;
    } else {
    return(
        <>
          {/* display navbar */}
            <Navbar/>
            <div style={{ display: 'flex', flexDirection: 'column', alignItems: 'center', justifyContent: 'center', marginTop:'30px'}}>
            <Typography variant="h4" gutterBottom>
              Search Inventory Data
            </Typography>
            {/* textfeild for search  */}
            <TextField
                variant="outlined"
                color="secondary"
                label="Search by keyword..."
                value={searchTerm}
                onChange={(e) => {filterPets(e.target.value);}}
                style={styles.textField}
            />
            
         </div>
            <div style={styles.container}>
            <div style={styles.contentContainer}>
              {/* displaying pet data */}
            <TableContainer component={Paper} style={styles.tableContainer}>
                <Table>
                    <TableHead>
                        <TableRow style={styles.tableHeaderCell}>
                            <TableCell>Animal</TableCell>
                            <TableCell>Description</TableCell>
                            <TableCell>Age</TableCell>
                            <TableCell>Price</TableCell>
                        </TableRow>
                    </TableHead>
                    <TableBody>
                      {/* if search textfeild is empty display all data */}
                    {searchTerm === '' ? (
            pets.map(pet => (
              <TableRow key={pet.id}>
                <TableCell>{pet.animal}</TableCell>
                <TableCell>{pet.description}</TableCell>
                <TableCell>{pet.age}</TableCell>
                <TableCell>{pet.price}</TableCell>
              </TableRow>
            ))
          ) : (searchResults.map(pet => (
            // is search keyword is mentioned display data accordingly
            <TableRow key={pet.id}>
              <TableCell>{pet.animal}</TableCell>
              <TableCell>{pet.description}</TableCell>
              <TableCell>{pet.age}</TableCell>
              <TableCell>{pet.price}</TableCell>
            </TableRow>
          ))
        )}
        </TableBody>
        </Table>
        </TableContainer>

      </div>
      </div>
          
      </>
    )
  }
}

 