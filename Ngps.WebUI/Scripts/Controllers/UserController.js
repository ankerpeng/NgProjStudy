
ngapp.controller("UserController", function ($scope, $http) {
    $scope.UserList;
    $http.get("../../JData/UserList.json").success(function (data) {
        console.log(data);
        $scope.UserList = data;
    });
    $scope.orderProp = 'CreateTime';
});


