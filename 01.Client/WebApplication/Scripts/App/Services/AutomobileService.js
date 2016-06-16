templateApp.factory('carData', function ($http, $log) {
    return {
        getCarData: function (successCallback) {
            $http(
            {
                method: 'GET',
                url: 'api/Car/Get'
            })
            .success(function (data, status, headers, config) {
                successCallback(data);
            })
            .error(function (data, status, headers, config) {
                $log.warn(data, status, headers(), config);
            });
        },

        carData: [
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
        ]
    };
});