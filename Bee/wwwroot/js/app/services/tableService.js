var TableService = function() {
    const beeTableBody = document.getElementsByTagName("tbody")[0];
    var appendBody = function(bees) {
       
        beeTableBody.innerHTML = "";
       
        for (const animal of bees) {
            appendAnimal(animal);
        }
    }

    var appendAnimal = function(animal) {
        let row = document.createElement('tr');
        
        let categroy = document.createElement('td');
        categroy.innerText = animal.category;

        let healthNumber = document.createElement('td');
        healthNumber.innerText = animal.healthNumber + '%';

        let status = document.createElement('td');
        status.innerText = animal.status;

        row.append(categroy,healthNumber,status);
        beeTableBody.append(row);

    }
    
    return {
        appendBody: appendBody
    }
}()