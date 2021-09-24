app.controller("coach_formationCreate",function($scope,ajax,$location){
  $scope.p = {};

    ajax.get("https://localhost:44368/api/Formation",
    function(resp){
      $scope.type = resp.data;

    },

    function(err){

    });

    $scope.AddFormation = function(p){
       //$scope.Name
       var nameError = false;
       if(p.Name == undefined)
       {
         nameError = true;
         $scope.nameError = "Formation Name field is required";
       }
       var typeError = false;
       if(p.Type == undefined)
       {
         typeError = true;
         $scope.typeError = "Formation Type filed is required";
       }

       if(!nameError && !typeError){
         ajax.post("https://localhost:44368/api/Formation/Add",p,
         function(resp){
             $location.path("/coach_formationRead");
         },
         function(err){});
       }


     };
});
