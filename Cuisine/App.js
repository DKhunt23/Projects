/**
 * Cuisine application - displays recipes photo, recipe title and recipe ingredients categorized as breakfast, snack, dinner 
 * and there is dropdown to filter data based on cuisine type - amercian, indian...
 * @author Dipsa Khunt
 */
import React, { useState, useEffect } from 'react';
import { View, Text, TextInput, Button, FlatList, Image ,Picker} from 'react-native';
import { StyleSheet } from 'react-native';

const App = () => {
  const [searchTerm, setSearchTerm] = useState(''); //value entered by user
  const [recipes, setRecipes] = useState([]); // all recipes
  const [selectedCuisineType, setSelectedCuisineType] = useState('all'); //cuisine type 
  const [filteredRecipes, setFilteredRecipes] = useState([]); // displayed filtered recipes
  const [selectedMealType, setSelectedMealType] = useState('');


  const edamamAppId = 'id'; //id
  const edamamAppKey = 'key'; //key

  useEffect(() => {
    const apiUrl = "https://api.edamam.com/api/recipes/v2?type=public&q="+searchTerm+"&app_id="+edamamAppId+"&app_key="+edamamAppKey+"&mealType=breakfast";
    fetch(apiUrl)
    .then(response => {
      if (!response.ok) {
        throw new Error(`HTTP error! Status: ${response.status}`);

      }
      return response.json();
    })
    .then(data => {
      
      setRecipes(data.hits);
      setFilteredRecipes(data.hits);
     
    })
    .catch(error => {
      // Handle errors
      console.error('Error fetching data:', error);
    });
  }, []);

  useEffect(() => {
    // filter recipes whenever the selected cuisine type changes
    newRecipes();
  }, [searchTerm,selectedMealType,selectedCuisineType]);

  /**
   * filters the recipe based on user choice
   */
  const newRecipes = () => {
    // filter the recipes based on the cusinie type selected by user
   
    const filtered = recipes.filter(recipe => {
     
      return (
        (selectedCuisineType === 'all' || recipe.recipe.cuisineType[0] === selectedCuisineType)
      );
    });

    // update the state with the filtered recipes
    // console.log("in new",filtered)
    setFilteredRecipes(filtered);
    
  };

  /**
   * 
   * @param {*} searchTerm value entered by user
   * @param {*} mealType button value --> button clicked by user
   */
  const handleSearch = (searchTerm,mealType,cusinieType) => {
    // setSelectedCuisineType(cusinieType);
    setSelectedMealType(mealType);
    // call the function to fetch data based on value entered by user and button clicked value
    fetchRecipes(searchTerm,mealType,cusinieType);
  };

  /**
   * 
   * @param {*} searchTerm - value entered by user
   * @param {*} mealType - button value --> button clicked by user
   */
  const fetchRecipes = async (searchTerm,mealType,cuisineType) => {
    try {
      //input value is not null then fetch data
      if(searchTerm != '')
      {
        if(cuisineType === 'all')
        {
          const response = await fetch(
            `https://api.edamam.com/api/recipes/v2?type=public&q=${searchTerm}&app_id=${edamamAppId}&app_key=${edamamAppKey}&mealType=${mealType}`
          );
          const data = await response.json();
          setRecipes(data.hits);
        }
        else{
          const response = await fetch(
            `https://api.edamam.com/api/recipes/v2?type=public&q=${searchTerm}&app_id=${edamamAppId}&app_key=${edamamAppKey}&cuisineType=${cuisineType}&mealType=${mealType}`
          );
          const data = await response.json();
          setRecipes(data.hits);

        }
       
      }
      
    } catch (error) {
      console.error('Error fetching recipes', error);
    }
  };

  /**
   * render the data set in recipes
   * @param {*} item - search keyword entered by user
   *        print - displays the data
   */
  const renderItem = ({ item }) => (
    <View style={styles.recipeItem}>
      {/* recipe image */}
      <Image source={{ uri: item.recipe.image }} style={styles.recipeImage} />  
      {/* recipe title */}
      <Text style={styles.recipeTitle}>{item.recipe.label}</Text>
      <Text style={styles.ingredientsTitle}>Cuisine Type: {item.recipe.cuisineType}</Text>
      {/* ingredient as heading */}
      <Text style={styles.ingredientsTitle}>Ingredients:</Text>
      {/* list of ingredients */}
      <View>
        {item.recipe.ingredientLines.map((ingredient, index) => (
          <Text key={index}>{ingredient}</Text>
        ))}
      </View>
    </View>
  );

  /**
   * displays the data on page
   */
  return (
    <View style={styles.container}>
      {/* heading */}
      <Text style={styles.appName}>Cuisinee</Text>
      <View style={styles.filterContainer}>
        <View style={styles.inputContainer}>
          {/* search input box */}
          <TextInput
            style={styles.input}
            placeholder="Enter ingredients(eg: apple)"
            onChangeText={(text) => setSearchTerm(text)}  //set search keyword entered by user
            value={searchTerm}
          />
        </View>

        <View style={styles.dropdownContainer}>
          {/* dropdown for cuisine type */}
          <Picker
            selectedValue={selectedCuisineType}
            style={styles.additionalFilterPicker}
            onValueChange={(itemValue) => setSelectedCuisineType(itemValue)} //set cusinie type selected by user
          >
          <Picker.Item label="All" value="all" />
          <Picker.Item label="American" value="american" />
          <Picker.Item label="French" value="french" />
          <Picker.Item label="Indian" value="indian" />
          <Picker.Item label="Italian" value="italian" />
          <Picker.Item label="Mexican" value="mexican" />
          <Picker.Item label="Chinese" value="chinese" />
        </Picker>
        </View>
        </View>

      {/* buttons for breakfast, snack, dinner for cusinie */}
      <View style={styles.buttonContainer}>
        <Button title="Breakfast" onPress={() => handleSearch(searchTerm,'breakfast',selectedCuisineType)} color="#3498db" />
        <Button title="Snack" onPress={() => handleSearch(searchTerm,'snack',selectedCuisineType)} color="#2ecc71" />
        <Button title="Lunch/Dinner" onPress={() => handleSearch(searchTerm,'dinner',selectedCuisineType)} color="#e74c3c" />
      </View>

      <View style={{flexDirection: 'row', justifyContent:'space-between'}}>
       {selectedCuisineType === 'all'? (recipes.length===0?(
        // if search value entered by user doesnot match display error
        <Text style={styles.noRecipeText}>No recipes found!!</Text>
    
        // displaying data based on button clicked value and if selected dropdown option is 'All' 
       ):(
        <FlatList
        data={recipes}
        renderItem={renderItem}
        keyExtractor={(item) => item.recipe.uri}
        numColumns={3} // set the number of columns
      />
      // displaying error message 'no recipe found' if cusinie type doesnot match any data
       )):(filteredRecipes.length===0?(
        <Text style={styles.noRecipeText}>No recipes found for the selected cuisine type.</Text>
    
        // displaying data based on cusinie type selected by user
       ):(
        <FlatList
          data={filteredRecipes}
          renderItem={renderItem}
          keyExtractor={(item) => item.recipe.uri}
          numColumns={3} // set the number of columns
        />
       ))}
      </View>
    </View>
  );
};

const styles = StyleSheet.create({
  // all elements in page
  container: {
    flex: 1,
    padding: 16,
    alignItems: 'center',
  },
  // heading style
  appName: {
    fontSize: 40,
    fontWeight: 'bold',
    marginTop: 50,
    marginBottom: 20,
  },
  // button 
  buttonContainer: {
    flexDirection: 'row',
    justifyContent: 'space-around',
    width: '20%',
    marginBottom: 20,
  },
  // style for data to b displayed
  recipeItem: {
    width:400,
    marginVertical: 10,
    paddingHorizontal: 10,
    textAlign:'center',
   
  },
  // image
  recipeImage: {
    width: 300,
    height: 200,
    borderRadius: 10,
  },
  // image title
  recipeTitle: {
    fontSize: 18,
    fontWeight: 'bold',
    marginVertical: 5,
  },
  // recipe heading - 'ingredient'
  ingredientsTitle: {
    fontSize: 16,
    fontWeight: 'bold',
    marginVertical: 5,
  },
  // style if not data found for recipe
  noRecipeText: {
    fontSize: 16,
    textAlign: 'center',
    fontWeight: 'bold',
    marginTop: 20,
    color: 'red',
  },
  // input and dropdown container
  filterContainer: {
    flexDirection: 'row',
    marginBottom: 10,
  },
  // input
  inputContainer: {
    flex: 8,
    marginRight: 10,
  },
  input: {
    height: 40,
    borderColor: 'gray',
    borderWidth: 1,
    paddingHorizontal: 10,
    borderRadius: 8,
    width: '100%',
  },
  // dropdown
  dropdownContainer: {
    flex: 4,
    marginRight: 10,
  },
  additionalFilterPicker: {
    height: 40,
    width: '100%',
    backgroundColor: 'white', 
    borderRadius: 8,
    borderWidth: 1,
    borderColor: 'gray',
    paddingHorizontal: 10,
  },
});

export default App;
