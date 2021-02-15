
// --- call fs --- //

var fs = require("fs");

// --- To create a JSON file ---///

const employeeCreate = {
    name: "Maria Sharapova",
    age: 50,
    employeeID: 234567,
    Designation: "CEO"
}
const jsonStringCreate = JSON.stringify(employeeCreate);
fs.writeFile('createdEmployee.json', jsonStringCreate, err => {
    if (err){
        console.log('Error writing file', err)
    }
    else {
        console.log("Successfully write file")
    }
})


// --- To read a json file ---//


fs.readFile('./dummy.json', 'utf8', (err, jsonString) => {
    if (err) {
        console.log("File read failed:", err)
        return
    }
    try {
        const employee = JSON.parse(jsonString)
        console.log("Employee name is:", employee.name) 
    }
    catch(err) {
        console.log('Error parsing JSON string:', err)
    }
})
