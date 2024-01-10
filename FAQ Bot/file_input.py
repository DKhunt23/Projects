"""
This file is to read data from txt file

Dipsa Khunt
"""
def file_input(filename):
    """storing data from file"""
    lines = []
    
    with open(filename) as file: # open the file specified
        for line in file:
                lines.append(line.strip()) # add each line in array removing space
            
    return lines





