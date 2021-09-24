app.controller("PlayerSearch",function($scope, ajax, $routeParams){

      //$scope.value="nazim";

      var search = $routeParams.search.toString();

       ajax.get("https://localhost:44368/api/player/search/"+search,success,error);
       function success(response){
           $scope.values = response.data;
       }
       function error(err){

       }
});
