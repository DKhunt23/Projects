//@author dipsa khunt
import Navbar from "../component/Navbar";
import image from "../images/baby_pet.jpg";
import React from 'react';
import { Typography, Paper, Container, Card, CardContent, CardMedia } from '@mui/material';

export default function aboutus(){
  return (
    <>
    {/* displaying navbar */}
    <Navbar/>

    {/* displaying in conatiner */}
    <Container style={{marginTop:'30px'}}>

      <Card style={{ marginTop: 20 }}>
        <CardMedia
          component="img"
          alt="Pet Store Image"
          height="380"
        
          image={image}  // Replace with the actual URL or path to your image
          style={{ objectFit: 'fit' }} 
        />
        <CardContent>
          <Typography variant="h4" gutterBottom>
            About Our Pet Store!
          </Typography>
          <Typography variant="body1" paragraph>
            We are dedicated to providing a wide variety of pets to meet the needs and preferences of every pet lover.
            Our inventory includes a diverse range of animals, from playful puppies to exotic birds and more.
          </Typography>
          <Typography variant="body1" paragraph>
            At our store, we prioritize the well-being of our pets, ensuring they are healthy, happy, and ready to become
            a cherished member of your family. Feel free to explore our inventory, ask our knowledgeable staff for assistance,
            and find the perfect companion for your home.
          </Typography>
        </CardContent>
      </Card>
    </Container>
    </>
    
    
  );
};





