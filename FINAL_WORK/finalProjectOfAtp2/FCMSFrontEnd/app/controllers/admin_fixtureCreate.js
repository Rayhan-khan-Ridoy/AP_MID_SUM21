app.controller("admin_fixtureCreate",function($scope,ajax,$location){
$scope.p = {};
    $scope.AddFixture = function(p){
       //$scope.Name
       var opponentError = false;
       if(p.Opponent == undefined)
       {
         opponentError = true;
         $scope.opponentError = "Opponent Team name should include"
       }
       var matchStatusError = false;
       if(p.Match_Status == undefined)
       {
         matchStatusError = true;
         $scope.matchStatusError = "Match status field is required"
       }
       var groundError = false;
       if(p.Ground_Name == undefined)
       {
         groundError = true;
         $scope.groundError = "please Add match ground name"
       }
       var dateError = false;
       if(p.Date == undefined)
       {
         dateError = true;
         $scope.dateError = "Match date field is required"
       }
       var resultError = false;
       if(p.Result == undefined)
       {
         resultError = true;
         $scope.resultError = "Result of the match is required"
       }
       if(!opponentError && !matchStatusError && !groundError && !dateError && !resultError){
         ajax.post("https://localhost:44368/api/Fixture/Add",p,
         function(resp){
             $location.path("/admin_fixtureRead1");
         },
         function(err){});
       }


     };
});
