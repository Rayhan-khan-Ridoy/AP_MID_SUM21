app.controller("deleteProduct", function ($scope, $http, ajax) {
  ajax.get("https://localhost:44364/api/product/{id}", success, error);
  function success(response) {

  }
  function error(error) {
    console.log(error);
  }

  };
});
