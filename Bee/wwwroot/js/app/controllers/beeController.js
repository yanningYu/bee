var BeeController = function(beeService, tableService) {
    var bees;
    var init = function() {
        list();
    }

    var list = function() {
        beeService.list(done, fail);
    }

    var done = function(data) {
        bees = data;
        tableService.appendBody(data);
    }

    var fail = function(error) {
        alert("Something failed");
    }

    return { 
        init: init
    }
}(BeeService, TableService)