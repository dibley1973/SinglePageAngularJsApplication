'use strict';

templateApp.controller('AutomobileController',
    function AutomobileController($scope) {
        $scope.cars = [
            {
                id: 1,
                make: 'Ford',
                model: 'Cortina',
                year: '1969',
                doors: '2',
                trim: 'GT'
            },
            {
                id: 2,
                make: 'Austin',
                model: 'Maxi',
                year: '1976',
                doors: '4',
                trim: 'L'
            }
        ];
        $scope.addCar = function() {
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