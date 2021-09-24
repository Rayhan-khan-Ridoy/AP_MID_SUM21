app.controller("admin_fixtureUpdate",function($scope,$http,ajax, $routeParams,$location){
$scope.p = {};
  var id = $routeParams.id;

  ajax.get("https://localhost:44368/api/Fixture/"+id, success,error);
    function success(response){
      $scope.p = response.data;
    }
    function error(error){

    }

    $scope.UpdateFixture = function(p){
       //$scope.Name
       var opponentError = false;
       if(p.Opponent == "")
       {
         opponentError = true;
         $scope.opponentError = "Opponent Team name should include"
       }
       var matchStatusError = false;
       if(p.Match_Status == "")
       {
         matchStatusError = true;
         $scope.matchStatusError = "Match status field is required"
       }
       var groundError = false;
       if(p.Ground_Name == "")
       {
         groundError = true;
         $scope.groundError = "please Add match ground name"
       }
       var dateError = false;
       if(p.Date == "")
       {
         dateError = true;
         $scope.dateError = "Match date field is required"
       }
       var resultError = false;
       if(p.Result == "")
       {
         resultError = true;
         $scope.resultError = "Result of the match is required"
       }
       if(!opponentError && !matchStatusError && !groundError && !dateError && !resultError){
         ajax.post("https://localhost:44368/api/Fixture/Edit/"+id,p,
         function(resp){
             $location.path("/admin_fixtureRead1");
         },
         function(err){});
       }


     };
});
