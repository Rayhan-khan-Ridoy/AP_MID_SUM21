var app = angular.module("myApp", ["ngRoute"]);
app.config(["$routeProvider","$locationProvider",function($routeProvider,$locationProvider) {

    $routeProvider
    .when("/", {
        templateUrl : "views/pages/demopage.html"
    })
    .when("/demo", {
        templateUrl : "views/pages/demopage.html",
        controller: 'demo'
    })
    .when("/demo2", {
        templateUrl : "views/pages/demo2.html",
          controller: 'demo2'
    })

    .when("/products", {
        templateUrl : "views/pages/products.html",
        controller: 'products'
    })
    .when("/addproduct", {
        templateUrl : "views/pages/addproduct.html",
        controller: 'addproduct'
    })

    .when("/categories", {
       templateUrl : "views/pages/categories.html",
       controller: 'category'
   })
   .when("/addcategory", {
       templateUrl : "views/pages/addcategory.html",
       controller: 'addcategory'
   })
   .when("/deleteProduct", {
       templateUrl : "views/pages/products.html",
       controller: 'deleteProduct'
   })
   .when("/order_making", {
        templateUrl : "views/pages/order_making.html",
        controller: 'order_making'
    })
    .when("/order_admin", {
        templateUrl : "views/pages/order_admin.html",
        controller: 'order_admin'
    })
    .when("/order_user/:id", {
        templateUrl : "views/pages/order_user.html",
        controller: 'order_user'
    })
    .otherwise({
        redirectTo:"/"
    });
      //$locationProvider.html5Mode(true);
      //$locationProvider.hashPrefix('');
      //if(window.history && window.history.pushState){
      //$locationProvider.html5Mode(true);
  //}

}]);
