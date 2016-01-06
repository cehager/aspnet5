(function () {
    angular.module("app-trips")
    .controller("tripsController", tripsController);

    function tripsController($http) {
        //when this function is called it returns and object (as in: f = new tripsController()) this == f (the new object)
        var vm = this;

        vm.trips = [];

        //vm.newTrip = {};
        vm.newTrip = {};

        vm.errorMessage = "";
        vm.isBusy = true;

        $http.get("/api/trips")
            .then(function (response) {
                //success
                angular.copy(response.data, vm.trips);
            },
             function (error) {
                 //failure
                 vm.errorMessage = "Failed to load data, try again: " + error.statusText;
             })
            .finally(function () {
                vm.isBusy = false;
            });

        vm.addTrip = function () {
            vm.isBusy = true;
            vm.errorMessage = '';

            $http.post("/api/trips", vm.newTrip)
            .then(function (response) {
                //success
                vm.trips.push(response.data);
                vm.newTrip = {};
            },
             function (error) {
                 //failure
                 vm.errorMessage = "Failed to save new trip, try again.";
             })
            .finally(function () {
                vm.isBusy = false;
            });


        };
    };
})();