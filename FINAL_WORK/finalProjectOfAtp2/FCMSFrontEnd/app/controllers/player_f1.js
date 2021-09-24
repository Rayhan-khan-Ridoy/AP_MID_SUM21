app.controller("player_f1",function($scope,$http,ajax){
  ajax.get("https://localhost:44368//api/Players/All",success,error);
    function success(response){
      $scope.players=response.data;
      $scope.sortColumn = "Name";
      $scope.reverseSort = false;
      $scope.sortData = function(column){
        $scope.reverseSort = ($scope.sortColumn == column) ? !$scope.reverseSort : false;
        $scope.sortColumn = column;
      }
      $scope.getSortClass = function(column){
        if($scope.sortColumn == column){
          return $scope.reverseSort ? 'arrow-down' : 'arrow-up';
        }
        return '';
      }
    }
    function error(error){

    }
});
