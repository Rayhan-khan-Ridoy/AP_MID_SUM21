app.controller("PlayerCreate",function($scope,ajax,$location){

    ajax.get("https://localhost:44368/api/Salary/Details",
    function(resp){
      $scope.Salary = resp.data;

    },

    function(err){

    });

    $scope.AddPlayer = function(p){
       //$scope.Name
       ajax.post("https://localhost:44368/api/Player/Add",p,
       function(resp){
           $location.path("/player_f2");
       },
       function(err){});

     };
});
