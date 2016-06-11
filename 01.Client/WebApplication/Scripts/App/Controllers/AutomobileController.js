'use strict';

templateApp.controller('AutomobileController',
    function AutomobileController($scope) {
        $scope.cars = [
            {
                make: 'Ford',
                model: 'Cortina',
                year: '1969'
            },
            {
                make: 'Austin',
                model: 'Maxi',
                year: '1976'
            }
        ];
    });