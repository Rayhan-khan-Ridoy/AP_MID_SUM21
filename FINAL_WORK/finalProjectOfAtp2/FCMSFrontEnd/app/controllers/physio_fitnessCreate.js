app.controller("physio_fitnessCreate",function($scope,ajax,$location){
  $scope.p = {};

    $scope.AddFitness = function(p){
       //$scope.Name
       var statusError = false;
       if(p.Status == undefined)
       {
         statusError = true;
         $scope.statusError = "Formation Name field is required";
       }
       if(!statusError){
         ajax.post("https://localhost:44368/api/Fitness/Add",p,
         function(resp){
             $location.path("/physio_fitnessRead");
         },
         function(err){});
       }


     };
});
