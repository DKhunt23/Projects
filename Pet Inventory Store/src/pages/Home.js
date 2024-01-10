//@author Dipsa Khunt
import Navbar from "../component/Navbar";
import petsimage from "../images/welcome.png";
import { Grid, Typography } from '@mui/material';

export default function Home(){
    return(
        <>
            {/* displaying navbar */}
            <Navbar />
            {/* displating image */}
            <Grid
                container
                direction="column"
                justifyContent="center"
                alignItems="center"
                spacing={3} 
                style={{ minHeight: '60vh' }}
            >
               
                <Grid item style={{ marginTop: '40px' }}>
                    <img
                        src={petsimage}
                        alt="Pet Inventory Image"
                        style={{ maxWidth: '90%', maxHeight: '90%' }}
                    />
                </Grid>
                
            </Grid>
        </>
    )
}