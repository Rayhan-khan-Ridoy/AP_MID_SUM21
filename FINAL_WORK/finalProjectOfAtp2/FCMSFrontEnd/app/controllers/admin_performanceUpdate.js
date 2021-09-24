app.controller("admin_performanceUpdate",function($scope,$http,ajax, $routeParams,$location){

  $scope.p = {};
  var id = $routeParams.id;

  ajax.get("https://localhost:44368/api/Performance/"+id, success,error);
    function success(response){
      $scope.p = response.data;
    }
    function error(error){

    }

    $scope.UpdatePerformance = function(p){
      var avgRatingError = false;
      if(p.Avg_Rating == undefined)
      {
        avgRatingError = true;
        $scope.arError = "Avregae Rating Should Include";
      }
      var goalsError = false;
      if(p.Goals == undefined)
      {
        goalsError = true;
        $scope.goalsError = "Total Goals Should Include";
      }
      var assistsError = false;
      if(p.Assists == undefined)
      {
        assistsError = true;
        $scope.assistsError = "Total Assists Should Include";
      }
      var acPassError = false;
      if(p.Accurate_Pass == undefined)
      {
        acPassError = true;
        $scope.acPassError = "Total Accurate Pass Given to Teaammate Should Include";
      }
      var keyPassError = false;
      if(p.Key_Pass == undefined)
      {
        keyPassError = true;
        $scope.keyPassError = "Total Key Pass Should Include";
      }
      var interceptionError = false;
      if(p.Interception == undefined)
      {
        interceptionError = true;
        $scope.interceptionError = "Total Interception has been made throughout the whole season should include";
      }
      var succesfullyTackledError = false;
      if(p.Successfully_Tackled == undefined)
      {
        succesfullyTackledError = true;
        $scope.succesfullyTackledError = "Successfully Tackled Should Include";
      }
      var chanceCreateError = false;
      if(p.Chance_Create == undefined)
      {
        chanceCreateError = true;
        $scope.chanceCreateError = "Total Chance Create Should Include";
      }
      var dribCompletedError = false;
      if(p.Dribbles_Completed == undefined)
      {
        dribCompletedError = true;
        $scope.dribCompletedError = "Total Dribbles Should Include";
      }
      var savesError = false;
      if(p.Saves == undefined)
      {
        savesError = true;
        $scope.savesError = "Total Saves Should Include";
      }
      var rCardError = false;
      if(p.Red_Cards == undefined)
      {
        rCardError = true;
        $scope.rCardError = "Total Red card shown by a refree should include";
      }
      var yCardError = false;
      if(p.Yellow_Cards == undefined)
      {
        yCardError = true;
        $scope.yCardError = "Total Yellow card shown by a refree should includ";
      }
      if(!avgRatingError && !goalsError && !assistsError &&  !acPassError &&!keyPassError
        && !interceptionError && !succesfullyTackledError &&!chanceCreateError && !dribCompletedError
         && !savesError &&!rCardError &&!yCardError){
        ajax.post("https://localhost:44368/api/PerformanceEdit/"+id,p,
        function(resp){
            $location.path("/PerformanceRead");
        },
        function(err){});
      }


     };
});
