// @author Dipsa Khunt
import Navbar from "../component/Navbar";
import React, { useState, useEffect } from 'react';
import { Typography,Table, TableBody, TableCell, TableContainer, TableHead, TableRow, Paper, Button, TextField, IconButton } from '@mui/material';
import DeleteIcon from '@mui/icons-material/Delete';
import EditIcon from '@mui/icons-material/Edit';
// styles for table and textfeild
const styles = {
  container: {
    display: 'flex',
    flexDirection: 'column',
    alignItems: 'center',
    justifyContent: 'center',
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

function Pets() {
  
    // isLoaded keeps track of whether the initial load of pet data from the
    // server has occurred.  pets is the array of pets data in the table, and 
    // searchResults is the array of pets data after a search request.
    const [isLoaded, setIsLoaded] = useState(false);
    const [data, setData] = useState([]);
    const [pets, setPets] = useState([]);
    //edit for editing info of pets
    const [editingId, setEditingId] = useState(null);
    const [editedAnimal, setEditedAnimal] = useState('');
    const [editedDescription, setEditedDescription] = useState('');
    const [editedAge, setEditedAge] = useState('');
    const [editedPrice,setEditedPrice] = useState('');

    // adding new pet data 
    const [formData, setFormData] = useState({
      id: null,
      animal: '',
      description: '',
      age: '',
      price: '',
    });
   
 
    /**
     * fetches all pet data from the server
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
    

    /**
     * add pet with specified data
     * @param {*} animal - name of animal
     * @param {*} description - info about animal
     * @param {*} age - age of animal
     * @param {*} price - price of animal
     */
    function addPet(animal,description,age,price)
    {
      fetch("http://localhost:3001/api?act=add&animal="+animal+"&description="+description+"&age="+age+"&price="+price)
      .then(res => res.json())
      .then(
        (result) => {
          fetchPets();
        })  
        setFormData({
          id: null,
          animal: '',
          description: '',
          age: '',
          price: '',
        });
    }
  
    /**
     * delete the pet information associated with specified id
     * @param {*} id - pet id 
     */
    function deletePet(id)
    {
      fetch("http://localhost:3001/api?act=delete&id="+id)
      .then(res => res.json())
      .then(
        (result) => {
          fetchPets();
        })    
    }
  
    /**
     * upadate pet information entered and if not entered upadate with previous value
     * @param {*} id - pet id
     * @param {*} animal - name of animal
     * @param {*} description - info related to animal
     * @param {*} age - age 
     * @param {*} price - price
     */
    function updatePet(id,animal,description,age,price)
    {
      fetch("http://localhost:3001/api?act=update&id="+id+"&animal="+animal+"&description="+description+"&age="+age+"&price="+price)
      .then(res => res.json())
      .then(
        (result) => {
          fetchPets();
        });
    }  
      
    const handleChange = (e) => {
      
      const { name, value } = e.target;
      setFormData((prevFormData) => ({
        ...prevFormData,
        [name]: value,
      }));
      console.log("formData",formData)

    };
    const isFormValid = () => {
      // Check if all required fields are filled
      return formData.animal && formData.description && formData.age && formData.price;
    };
  
    const handleUpdate = (id) => {
      console.log(editedAnimal, editedDescription, editedAge)
      if(editedAnimal === '' || editedDescription==='' || editedAge ==='' || editedPrice==='')
      {
        alert('Please fill in the text field');
      }
      else{
        updatePet(id,editedAnimal,editedDescription,editedAge,editedPrice);
      
        setEditingId(null);
        setEditedAnimal('');
        setEditedDescription('');
        setEditedAge('');
        setEditedPrice('');
      }
          
    };
    
    // If data has loaded, render the table of pets, 
    if (!isLoaded) {
      return <div>Loading...</div>;
    } else {
      return (
        <div>
            {/* display navigation bar */}
            <Navbar/>
           
          <div style={{ display: 'flex', flexDirection: 'column', alignItems: 'center', justifyContent: 'center', marginTop:'30px'}}>
            <Typography variant="h4" gutterBottom>
              Inventory Data
            </Typography>
          </div>
          <div style={styles.container}>
          <div style={styles.contentContainer}>
            {/* displaying pet data in table form */}
            <TableContainer component={Paper} style={styles.tableContainer}>
                <Table>
                    <TableHead>
                        <TableRow style={styles.tableHeaderCell}>
                            <TableCell>Animal</TableCell>
                            <TableCell>Description</TableCell>
                            <TableCell>Age</TableCell>
                            <TableCell>Price</TableCell>
                            <TableCell>Edit</TableCell>
                            <TableCell>Delete</TableCell>
                        </TableRow>
                    </TableHead>
           <TableBody>
            {/* if edit button is clicked display textfeild */}
            {pets.map(pet => (
              <TableRow key={pet.id}>
                 {editingId === pet.id ? (
            <>
            <TableCell>
            <TextField
                type="text"
                size="small"
                value={editedAnimal}
                onChange={(e) => setEditedAnimal(e.target.value)}
              />
            </TableCell>
              <TableCell>
              <TextField
                type="text"
                size="small"
                value={editedDescription}
                onChange={(e) => setEditedDescription(e.target.value)}

              />
              </TableCell>
             <TableCell>
             <TextField
                type="text"
                size="small"
                value={editedAge}
                onChange={(e) => setEditedAge(e.target.value)}
              />
             </TableCell>
              <TableCell>
              <TextField
                type="text"
                size="small"
                value={editedPrice}
                onChange={(e) => setEditedPrice(e.target.value)}
              />
              </TableCell>
             <TableCell>
                <Button variant="outlined" color="secondary" onClick={() => handleUpdate(pet.id)} >Save</Button>
             </TableCell>
             <TableCell>
               <Button variant="outlined" color="secondary" onClick={() => handleUpdate(null)}>Cancel</Button>
             </TableCell>
              
            </>
          ) : (
            // if edit button is not clicked display data with edit and delete button
            <>
               <TableCell>{pet.animal}</TableCell> 
                <TableCell>{pet.description}</TableCell>
                <TableCell>{pet.age}</TableCell>
                <TableCell>{pet.price}</TableCell>
                <TableCell>
                <EditIcon variant="outlined" color="secondary" onClick={() => {setEditingId(pet.id); setEditedAnimal(pet.animal);setEditedDescription(pet.description);setEditedAge(pet.age);setEditedPrice(pet.price)}}/>
                </TableCell>
                <TableCell>
                <DeleteIcon variant="outlined" color="secondary"  onClick={() => deletePet(pet.id)}/>
                </TableCell>
            
            </>
          )}
          </TableRow> 
            ))}
            {/* textfeild for adding pet information */}
            <TableRow>
              <TableCell>
                <TextField
                  required
                  label="animal"
                  type="text"
                  name="animal"
                  size="small"
                  value={formData.animal}
                  onChange={handleChange}
                />
              </TableCell>
              <TableCell>
                <TextField
                  type="text"
                  label="description"
                  name="description"
                  size="small"
                  value={formData.description}
                  onChange={handleChange}
                  required
                />
              </TableCell>
              <TableCell>
                <TextField
                  type="text"
                  name="age"
                  label="age"
                  size="small"
                  value={formData.age}
                  onChange={handleChange}
                  required
                />
              </TableCell>
              <TableCell>
                <TextField
                  type="text"
                  label="price"
                  name="price"
                  size="small"
                  value={formData.price}
                  onChange={handleChange}
                  required
                />
              </TableCell>
              <TableCell>
                <Button variant="outlined" color="primary" onClick={()=>{addPet(formData.animal,formData.description,formData.age,formData.price)}} disabled={!isFormValid() }type="submit">Add</Button>
              </TableCell>
            </TableRow>
            </TableBody>
          </Table>
          </TableContainer>
          </div>
          </div>
      </div>
      );
    }
  }
  

export default Pets;