var BeeService = function() {
    var list = function(done, fail) {
        $.get('/api/bee/list').done(done).fail(fail);
    }

    var damage = function(id, done, fail) {
        $.get(`/api/bee/damage/${id}`).done(done).fail(fail);
    };

    return {
        list: list,
        damage: damage
    }
}