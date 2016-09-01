(function(app, undefined) {
    'use strict';
    app.service('pizzaService', ['$http', '$q', function($http, $q) {
        
        this.getPizza = function() {
            var deferred = $q.defer(),
                pizza;
            $http.get('json/readyPizza.json').success(function(data) {
                deferred.resolve(data, 100);
            }).error(function() {
                bootbox.alert('Произошла ошибка загрузки данных с сервера.');
            });
            
            return deferred.promise;
        };
        
    }]);
})(app);