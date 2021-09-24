app.controller("admin_physioRead",function($scope,$http,ajax){
  ajax.get("https://localhost:44368/api/Physio",success,error);
    function success(response){
      $scope.coach = response.data;
    }
    function error(error){

    }
});
