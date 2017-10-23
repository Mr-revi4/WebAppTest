app.service("APIService", function ($http) {
    this.getEnt = function () {
        return $http.get("api/Entity")
    }
});   