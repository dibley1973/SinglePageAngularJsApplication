﻿'use strict';

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
    });