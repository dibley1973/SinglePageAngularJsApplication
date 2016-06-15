'use strict';

templateApp.controller('AutomobileEditController',
    function AutomobileEditController($scope) {
        $scope.completeCar = function (car, newCarForm) {
            if (newCarForm.$valid) {
                $scope.cars.push(car);
                window.alert('car ' + car.make + ' - ' + car.model + ' saved!');
                $.mobile.changePage('#car-list');
            }
        };
        $scope.cancelCar = function () {
            $.mobile.changePage('#car-list');
        }
    }
);