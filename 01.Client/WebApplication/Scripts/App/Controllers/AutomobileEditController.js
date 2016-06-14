'use strict';

templateApp.controller('AutomobileEditController',
    function AutomobileEditController($scope) {
        $scope.completeCar = function (car) {
            $scope.cars.push(car);
            $.mobile.changePage('#car-list');
        };
        $scope.cancelCar = function () {
            $.mobile.changePage('#car-list');
        }
    }
);