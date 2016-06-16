'use strict';

templateApp.controller('AutomobileController',
    function AutomobileController($scope, carData) {
        $scope.cars = carData.carData;

        $scope.cars = carData.getCarData(function (cars) {
            $scope.cars = cars;
        });


        $scope.addCar = function () {
            var car = {
                id: 1,
                make: 'Make',
                model: 'Model',
                year: '2000',
                doors: '2',
                trim: ''
            }
            $scope.cars.push(car);
        };
        $scope.selectCar = function (car) {
            $.mobile.changePage('#car-list');
        }
    });