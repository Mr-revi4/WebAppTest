app.controller('APIController', function ($scope, APIService) {
    getAll();

    function getAll() {
        var servCall = APIService.getEnt();
        servCall.then(function (d) {
            $scope.entity = d.data;
        }, function (error) {
                $log.error('Oops! Something went wrong while fetching the data.')
            })
    }
})