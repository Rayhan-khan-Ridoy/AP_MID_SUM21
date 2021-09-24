var app = angular.module("myApp", ["ngRoute"]);
app.config(["$routeProvider", "$locationProvider", function($routeProvider, $locationProvider) {

  $routeProvider
    .when("/", {
      templateUrl: "views/pages/index.html"
    })
    .when("/demo", {
      templateUrl: "views/pages/demopage.html",
      controller: 'demo'
    })
    .when("/player_f", {
      templateUrl: "views/pages/players.html",
      controller: 'player_f'
    })

    .when("/coach_f", {
      templateUrl: "views/pages/coach.html",
      controller: 'coach_f'
    })
    .when("/coach_f1", {
      templateUrl: "views/pages/coach1.html",
      controller: 'coach_f1'
    })
    .when("/physio_f", {
      templateUrl: "views/pages/physio.html",
      controller: 'physio_f'
    })
    .when("/admin_f", {
      templateUrl: "views/pages/admin.html",
      controller: 'admin_f'
    })

    .when("/admin_playerSearch:search", {
      templateUrl: "views/pages/playersSearchValue.html",
      controller: 'PlayerSearch'
    })

    .when("/SearchGK", {
      templateUrl: "views/pages/admin_playerGK.html",
      controller: 'admin_playerGK'
    })

    .when("/SearchCF", {
      templateUrl: "views/pages/admin_playerCF.html",
      controller: 'admin_playerCF'
    })

    .when("/SearchWingers", {
      templateUrl: "views/pages/admin_playerWingers.html",
      controller: 'admin_playerWingers'
    })

    .when("/SearchCMF", {
      templateUrl: "views/pages/admin_playerCMF.html",
      controller: 'admin_playerCMF'
    })
    .when("/SearchDMF", {
      templateUrl: "views/pages/admin_playerDMF.html",
      controller: 'admin_playerDMF'
    })
    .when("/SearchCB", {
      templateUrl: "views/pages/admin_playerCB.html",
      controller: 'admin_playerCB'
    })




    .when("/loginPlayer", {
      templateUrl: "views/pages/loginForm.html",
      controller: 'loginPlayer'
    })
    .when("/loginAdmin", {
      templateUrl: "views/pages/loginForm.html",
      controller: 'loginAdmin'
    })
    .when("/loginCoach", {
      templateUrl: "views/pages/loginForm.html",
      controller: 'loginCoach'
    })
    .when("/loginPhysio", {
      templateUrl: "views/pages/loginForm.html",
      controller: 'loginPhysio'
    })





    .when("/playerDashboard", {
      templateUrl: "views/pages/playerDashboard.html",
      controller: 'playerDashboard'
    })
    .when("/adminDashboard", {
      templateUrl: "views/pages/adminDashboard.html",
      controller: 'adminDashboard'
    })







    .when("/admin_registration", {
      templateUrl: "views/pages/admin_registrationForm.html",
      controller: 'admin_registration'
    })

    .when("/admin_coachCreate", {
      templateUrl: "views/pages/admin_coachCreateForm.html",
      controller: 'admin_coachCreate'
    })

    .when("/admin_coachUpdate:id", {
      templateUrl: "views/pages/admin_coachUpdateForm.html",
      controller: 'admin_coachUpdate'
    })
    .when("/admin_coachDelete:id", {
      templateUrl: "views/pages/coach.html",
      controller: 'admin_coachDelete'
    })
    .when("/admin_coachRead", {
      templateUrl: "views/pages/coach.html",
      controller: 'admin_coachRead'
    })




    .when("/admin_fixtureCreate", {
      templateUrl: "views/pages/admin_fixtureCreateForm.html",
      controller: 'admin_fixtureCreate'
    })
    .when("/admin_fixtureRead", {
      templateUrl: "views/pages/fixtures.html",
      controller: 'admin_fixtureRead'
    })
    .when("/admin_fixtureDelete", {
      templateUrl: "views/pages/fixtures.html",
      controller: 'admin_fixtureDelete'
    })
    .when("/admin_fixtureUpdate", {
      templateUrl: "views/pages/admin_fixtureCreateForm.html",
      controller: 'admin_fixtureUpdate'
    })



    .when("/admin_playersCreate", {
      templateUrl: "views/pages/admin_playersCreateForm.html",
      controller: 'admin_playersCreate'
    })
    .when("/admin_playerDetails:id", {
      templateUrl: "views/pages/player_details.html",
      controller: 'admin_playerDetails'
    })
    .when("/admin_playerDelete:id", {
      templateUrl: "views/pages/admin_playerDelete.html",
      controller: 'admin_playerDelete'
    })
    .when("/admin_playerUpdate:id", {
      templateUrl: "views/pages/admin_playerUpdate.html",
      controller: 'admin_playersUpdate'
    })


    .when("/admin_physioCreate", {
      templateUrl: "views/pages/admin_physioCreateForm.html",
      controller: 'admin_physioCreate'
    })
    .when("/admin_physioRead", {
      templateUrl: "views/pages/physio1.html",
      controller: 'admin_physioRead'
    })
    .when("/admin_physioDelete:id", {
      templateUrl: "views/pages/physio.html",
      controller: 'admin_physioDelete'
    })
    .when("/admin_physioUpdate:id", {
      templateUrl: "views/pages/admin_physioUpdate.html",
      controller: 'admin_physioUpdate'
    })


    .when("/admin_salaryCreate", {
      templateUrl: "views/pages/admin_salaryCreateForm.html",
      controller: 'admin_salaryCreate'
    })
    .when("/admin_salaryRead", {
      templateUrl: "views/pages/salary.html",
      controller: 'admin_salaryRead'
    })
    .when("/admin_salaryUpdate:id", {
      templateUrl: "views/pages/admin_salaryUpdateForm.html",
      controller: 'admin_salaryUpdate'
    })
    .when("/admin_salaryDelete:id", {
      templateUrl: "views/pages/salary.html",
      controller: 'admin_salaryDelete'
    })

    .when("/coach_formationCreate", {
      templateUrl: "views/pages/coach_formationCreateForm.html",
      controller: 'coach_formationCreate'
    })
    .when("/coach_formationRead", {
      templateUrl: "views/pages/formation.html",
      controller: 'coach_formationRead'
    })
    .when("/coach_formationUpdate", {
      templateUrl: "views/pages/coach_formationCreateForm.html",
      controller: 'coach_formationUpdate'
    })
    .when("/coach_formationDelete", {
      templateUrl: "views/pages/formation.html",
      controller: 'coach_formationDelete'
    })

    .when("/physio_fitnessCreate", {
      templateUrl: "views/pages/physio_fitnessCreateForm.html",
      controller: 'physio_fitnessCreate'
    })
    .when("/physio_fitnessRead", {
      templateUrl: "views/pages/fitness.html",
      controller: 'physio_fitnessRead'
    })
    .when("/physio_fitnessUpdate", {
      templateUrl: "views/pages/physio_fitnessCreateForm.html",
      controller: 'physio_fitnessUpdate'
    })
    .when("/physio_fitnessDelete", {
      templateUrl: "views/pages/fitness.html",
      controller: 'physio_fitnessDelete'
    })


    .when("/fixtures", {
      templateUrl: "views/pages/fixtures.html",
      controller: 'fixtures'
    })

    .when("/performance", {
      templateUrl: "views/pages/performance.html",
      controller: 'performance'
    })


    .when("/player_f", {
      templateUrl: "views/pages/players.html",
      controller: 'player_f'
    })
    .when("/player_f1", {
      templateUrl: "views/pages/players1.html",
      controller: 'player_f1'
    })
    .when("/player_f2", {
      templateUrl: "views/pages/players2.html",
      controller: 'player_f2'
    })



    .when("/player_editPassword", {
      templateUrl: "views/pages/players_loginInfo.html",
      controller: 'player_editPassword'
    })

    .when("/coach_editPassword", {
      templateUrl: "views/pages/coach_loginInfo.html",
      controller: 'coach_editPassword'
    })

    .when("/physio_editPassword", {
      templateUrl: "views/pages/physio_loginInfo.html",
      controller: 'physio_editPassword'
    })




    .otherwise({
      redirectTo: "/"
    });
  //$locationProvider.html5Mode(true);
  //$locationProvider.hashPrefix('');
  //if(window.history && window.history.pushState){
  //$locationProvider.html5Mode(true);
  //}

}]);
var app = angular.module("myApp", ["ngRoute"]);
app.config(["$routeProvider", "$locationProvider", function($routeProvider, $locationProvider) {

  $routeProvider
    .when("/", {
      templateUrl: "views/pages/index.html"
    })
    .when("/demo", {
      templateUrl: "views/pages/demopage.html",
      controller: 'demo'
    })
    .when("/player_f", {
      templateUrl: "views/pages/players.html",
      controller: 'player_f'
    })

    .when("/coach_f", {
      templateUrl: "views/pages/coach.html",
      controller: 'coach_f'
    })
    .when("/coach_f1", {
      templateUrl: "views/pages/coach1.html",
      controller: 'coach_f1'
    })
    .when("/physio_f", {
      templateUrl: "views/pages/physio.html",
      controller: 'physio_f'
    })
    .when("/admin_f", {
      templateUrl: "views/pages/admin.html",
      controller: 'admin_f'
    })

    .when("/admin_playerSearch:search", {
      templateUrl: "views/pages/playersSearchValue.html",
      controller: 'PlayerSearch'
    })

    .when("/SearchGK", {
      templateUrl: "views/pages/admin_playerGK.html",
      controller: 'admin_playerGK'
    })

    .when("/SearchCF", {
      templateUrl: "views/pages/admin_playerCF.html",
      controller: 'admin_playerCF'
    })

    .when("/SearchWingers", {
      templateUrl: "views/pages/admin_playerWingers.html",
      controller: 'admin_playerWingers'
    })

    .when("/SearchCMF", {
      templateUrl: "views/pages/admin_playerCMF.html",
      controller: 'admin_playerCMF'
    })
    .when("/SearchDMF", {
      templateUrl: "views/pages/admin_playerDMF.html",
      controller: 'admin_playerDMF'
    })
    .when("/SearchCB", {
      templateUrl: "views/pages/admin_playerCB.html",
      controller: 'admin_playerCB'
    })

    .when("/PlayerSalaryDetails:id", {
      templateUrl: "views/pages/PlayerSalaryDetails.html",
      controller: 'PlayerSalaryDetails'
    })








    .when("/loginPlayer", {
      templateUrl: "views/pages/loginForm.html",
      controller: 'loginPlayer'
    })
    .when("/loginAdmin", {
      templateUrl: "views/pages/loginForm.html",
      controller: 'loginAdmin'
    })
    .when("/loginCoach", {
      templateUrl: "views/pages/loginForm.html",
      controller: 'loginCoach'
    })
    .when("/loginPhysio", {
      templateUrl: "views/pages/loginForm.html",
      controller: 'loginPhysio'
    })

    .when("/playerDashboard", {
      templateUrl: "views/pages/playerDashboard.html",
      controller: 'playerDashboard'
    })
    .when("/adminDashboard", {
      templateUrl: "views/pages/adminDashboard.html",
      controller: 'adminDashboard'
    })
    .when("/coachDashboard", {
      templateUrl: "views/pages/coachDashboard.html",
      controller: 'coachDashboard'
    })
    .when("/physioDashboard", {
      templateUrl: "views/pages/physioDashboard.html",
      controller: 'physioDashboard'
    })





    .when("/admin_registration", {
      templateUrl: "views/pages/admin_registrationForm.html",
      controller: 'admin_registration'
    })

    .when("/admin_coachCreate", {
      templateUrl: "views/pages/admin_coachCreateForm.html",
      controller: 'admin_coachCreate'
    })

    .when("/admin_coachUpdate:id", {
      templateUrl: "views/pages/admin_coachUpdateForm.html",
      controller: 'admin_coachUpdate'
    })
    .when("/admin_coachDelete:id", {
      templateUrl: "views/pages/coach.html",
      controller: 'admin_coachDelete'
    })
    .when("/admin_coachRead", {
      templateUrl: "views/pages/coach.html",
      controller: 'admin_coachRead'
    })





    .when("/admin_fixtureRead", {
      templateUrl: "views/pages/fixtures.html",
      controller: 'admin_fixtureRead'
    })
    .when("/admin_fixtureCreate", {
        templateUrl : "views/pages/admin_fixtureCreateForm.html",
        controller: 'admin_fixtureCreate'
    })
    .when("/admin_fixtureRead1", {
        templateUrl : "views/pages/fixtures1.html",
          controller: 'admin_fixtureRead1'
    })
    .when("/admin_fixtureDelete:id", {
        templateUrl : "views/pages/fixtures.html",
          controller: 'admin_fixtureDelete'
    })
    .when("/admin_fixtureUpdate:id", {
        templateUrl : "views/pages/admin_fixtureUpdate.html",
          controller: 'admin_fixtureUpdate'
    })




    .when("/admin_playersCreate", {
      templateUrl: "views/pages/admin_playersCreateForm.html",
      controller: 'admin_playersCreate'
    })
    .when("/admin_playerDetails:id", {
      templateUrl: "views/pages/player_details.html",
      controller: 'admin_playerDetails'
    })
    .when("/admin_playerDelete:id", {
      templateUrl: "views/pages/admin_playerDelete.html",
      controller: 'admin_playerDelete'
    })
    .when("/admin_playerUpdate:id", {
      templateUrl: "views/pages/admin_playerUpdate.html",
      controller: 'admin_playersUpdate'
    })

    .when("/admin_physioCreate", {
      templateUrl: "views/pages/admin_physioCreateForm.html",
      controller: 'admin_physioCreate'
    })
    .when("/admin_physioRead", {
      templateUrl: "views/pages/physio1.html",
      controller: 'admin_physioRead'
    })
    .when("/admin_physioDelete:id", {
      templateUrl: "views/pages/physio.html",
      controller: 'admin_physioDelete'
    })
    .when("/admin_physioUpdate:id", {
      templateUrl: "views/pages/admin_physioUpdate.html",
      controller: 'admin_physioUpdate'
    })


    .when("/admin_salaryCreate", {
      templateUrl: "views/pages/admin_salaryCreateForm.html",
      controller: 'admin_salaryCreate'
    })
    .when("/admin_salaryRead", {
      templateUrl: "views/pages/salary.html",
      controller: 'admin_salaryRead'
    })
    .when("/admin_salaryUpdate:id", {
      templateUrl: "views/pages/admin_salaryUpdateForm.html",
      controller: 'admin_salaryUpdate'
    })
    .when("/admin_salaryDelete:id", {
      templateUrl: "views/pages/salary.html",
      controller: 'admin_salaryDelete'
    })


    .when("/coach_formationCreate", {
        templateUrl : "views/pages/coach_formationCreateForm.html",
        controller: 'coach_formationCreate'
    })
    .when("/coach_formationRead", {
        templateUrl : "views/pages/formation.html",
          controller: 'coach_formationRead'
    })
    .when("/coach_formationUpdate:id", {
        templateUrl : "views/pages/coach_formationUpdateForm.html",
          controller: 'coach_formationUpdate'
    })
    .when("/coach_formationDelete:id", {
        templateUrl : "views/pages/formation.html",
          controller: 'coach_formationDelete'
    })



    .when("/physio_fitnessCreate", {
        templateUrl : "views/pages/physio_fitnessCreateForm.html",
        controller: 'physio_fitnessCreate'
    })
    .when("/physio_fitnessRead", {
        templateUrl : "views/pages/fitness.html",
          controller: 'physio_fitnessRead'
    })
    .when("/physio_fitnessUpdate:id", {
        templateUrl : "views/pages/physio_fitnessUpdateForm.html",
          controller: 'physio_fitnessUpdate'
    })
    .when("/physio_fitnessDelete:id", {
        templateUrl : "views/pages/fitness.html",
          controller: 'physio_fitnessDelete'
    })


    .when("/fixtures", {
      templateUrl: "views/pages/fixtures.html",
      controller: 'fixtures'
    })



    .when("/performance", {
      templateUrl: "views/pages/performance.html",
      controller: 'performance'
    })
    .when("/PerformanceRead", {
      templateUrl: "views/pages/performance1.html",
      controller: 'admin_performanceRead'
    })

    .when("/admin_PerformanceCreate", {
      templateUrl: "views/pages/admin_PerformanceCreateForm.html",
      controller: 'admin_PerformanceCreate'
    })

    .when("/admin_PerformanceUpdate:id", {
      templateUrl: "views/pages/admin_PerformanceUpdateForm.html",
      controller: 'admin_performanceUpdate'
    })
    .when("/admin_PerformanceDetails:id", {
      templateUrl: "views/pages/performanceDetails.html",
      controller: 'admin_PerformanceDetails'
    })

    .when("/admin_PerformanceDelete:id", {
      templateUrl: "views/pages/performance.html",
      controller: 'admin_PerformanceDelete'
    })




    .when("/player_f", {
      templateUrl: "views/pages/players.html",
      controller: 'player_f'
    })
    .when("/player_f1", {
      templateUrl: "views/pages/players1.html",
      controller: 'player_f1'
    })
    .when("/coach_playerInfo", {
      templateUrl: "views/pages/coach_PlayerInfo.html",
      controller: 'player_f1'
    })
    .when("/player_f2", {
      templateUrl: "views/pages/players2.html",
      controller: 'player_f2'
    })



    .when("/player_editPassword", {
      templateUrl: "views/pages/players_loginInfo.html",
      controller: 'player_editPassword'
    })

    .when("/coach_editPassword", {
      templateUrl: "views/pages/coach_loginInfo.html",
      controller: 'coach_editPassword'
    })

    .when("/physio_editPassword", {
      templateUrl: "views/pages/physio_loginInfo.html",
      controller: 'physio_editPassword'
    })




    .otherwise({
      redirectTo: "/"
    });
  //$locationProvider.html5Mode(true);
  //$locationProvider.hashPrefix('');
  //if(window.history && window.history.pushState){
  //$locationProvider.html5Mode(true);
  //}

var app = angular.module("myApp", ["ngRoute"]);
app.config(["$routeProvider", "$locationProvider", function($routeProvider, $locationProvider) {

  $routeProvider
    .when("/", {
      templateUrl: "views/pages/index.html"
    })
    .when("/demo", {
      templateUrl: "views/pages/demopage.html",
      controller: 'demo'
    })
    .when("/player_f", {
      templateUrl: "views/pages/players.html",
      controller: 'player_f'
    })

    .when("/coach_f", {
      templateUrl: "views/pages/coach.html",
      controller: 'coach_f'
    })
    .when("/coach_f1", {
      templateUrl: "views/pages/coach1.html",
      controller: 'coach_f1'
    })
    .when("/physio_f", {
      templateUrl: "views/pages/physio.html",
      controller: 'physio_f'
    })
    .when("/admin_f", {
      templateUrl: "views/pages/admin.html",
      controller: 'admin_f'
    })

    .when("/admin_playerSearch:search", {
      templateUrl: "views/pages/playersSearchValue.html",
      controller: 'PlayerSearch'
    })

    .when("/SearchGK", {
      templateUrl: "views/pages/admin_playerGK.html",
      controller: 'admin_playerGK'
    })

    .when("/SearchCF", {
      templateUrl: "views/pages/admin_playerCF.html",
      controller: 'admin_playerCF'
    })

    .when("/SearchWingers", {
      templateUrl: "views/pages/admin_playerWingers.html",
      controller: 'admin_playerWingers'
    })

    .when("/SearchCMF", {
      templateUrl: "views/pages/admin_playerCMF.html",
      controller: 'admin_playerCMF'
    })
    .when("/SearchDMF", {
      templateUrl: "views/pages/admin_playerDMF.html",
      controller: 'admin_playerDMF'
    })
    .when("/SearchCB", {
      templateUrl: "views/pages/admin_playerCB.html",
      controller: 'admin_playerCB'
    })




    .when("/loginPlayer", {
      templateUrl: "views/pages/loginForm.html",
      controller: 'loginPlayer'
    })
    .when("/loginAdmin", {
      templateUrl: "views/pages/loginForm.html",
      controller: 'loginAdmin'
    })
    .when("/loginCoach", {
      templateUrl: "views/pages/loginForm.html",
      controller: 'loginCoach'
    })
    .when("/loginPhysio", {
      templateUrl: "views/pages/loginForm.html",
      controller: 'loginPhysio'
    })





    .when("/playerDashboard", {
      templateUrl: "views/pages/playerDashboard.html",
      controller: 'playerDashboard'
    })
    .when("/adminDashboard", {
      templateUrl: "views/pages/adminDashboard.html",
      controller: 'adminDashboard'
    })





    .when("/admin_registration", {
      templateUrl: "views/pages/admin_registrationForm.html",
      controller: 'admin_registration'
    })

    .when("/admin_coachCreate", {
      templateUrl: "views/pages/admin_coachCreateForm.html",
      controller: 'admin_coachCreate'
    })

    .when("/admin_coachUpdate:id", {
      templateUrl: "views/pages/admin_coachUpdateForm.html",
      controller: 'admin_coachUpdate'
    })
    .when("/admin_coachDelete:id", {
      templateUrl: "views/pages/coach.html",
      controller: 'admin_coachDelete'
    })
    .when("/admin_coachRead", {
      templateUrl: "views/pages/coach.html",
      controller: 'admin_coachRead'
    })




    .when("/admin_fixtureCreate", {
      templateUrl: "views/pages/admin_fixtureCreateForm.html",
      controller: 'admin_fixtureCreate'
    })
    .when("/admin_fixtureRead", {
      templateUrl: "views/pages/fixtures.html",
      controller: 'admin_fixtureRead'
    })
    .when("/admin_fixtureDelete", {
      templateUrl: "views/pages/fixtures.html",
      controller: 'admin_fixtureDelete'
    })
    .when("/admin_fixtureUpdate", {
      templateUrl: "views/pages/admin_fixtureCreateForm.html",
      controller: 'admin_fixtureUpdate'
    })



    .when("/admin_playersCreate", {
      templateUrl: "views/pages/admin_playersCreateForm.html",
      controller: 'admin_playersCreate'
    })
    .when("/admin_playerDetails:id", {
      templateUrl: "views/pages/player_details.html",
      controller: 'admin_playerDetails'
    })
    .when("/admin_playerDelete:id", {
      templateUrl: "views/pages/admin_playerDelete.html",
      controller: 'admin_playerDelete'
    })
    .when("/admin_playerUpdate:id", {
      templateUrl: "views/pages/admin_playerUpdate.html",
      controller: 'admin_playersUpdate'
    })


    .when("/admin_physioCreate", {
      templateUrl: "views/pages/admin_physioCreateForm.html",
      controller: 'admin_physioCreate'
    })
    .when("/admin_physioRead", {
      templateUrl: "views/pages/physio1.html",
      controller: 'admin_physioRead'
    })
    .when("/admin_physioDelete:id", {
      templateUrl: "views/pages/physio.html",
      controller: 'admin_physioDelete'
    })
    .when("/admin_physioUpdate:id", {
      templateUrl: "views/pages/admin_physioUpdate.html",
      controller: 'admin_physioUpdate'
    })


    .when("/admin_salaryCreate", {
      templateUrl: "views/pages/admin_salaryCreateForm.html",
      controller: 'admin_salaryCreate'
    })
    .when("/admin_salaryRead", {
      templateUrl: "views/pages/salary.html",
      controller: 'admin_salaryRead'
    })
    .when("/admin_salaryUpdate:id", {
      templateUrl: "views/pages/admin_salaryUpdateForm.html",
      controller: 'admin_salaryUpdate'
    })
    .when("/admin_salaryDelete:id", {
      templateUrl: "views/pages/salary.html",
      controller: 'admin_salaryDelete'
    })

    .when("/coach_formationCreate", {
      templateUrl: "views/pages/coach_formationCreateForm.html",
      controller: 'coach_formationCreate'
    })
    .when("/coach_formationRead", {
      templateUrl: "views/pages/formation.html",
      controller: 'coach_formationRead'
    })
    .when("/coach_formationUpdate", {
      templateUrl: "views/pages/coach_formationCreateForm.html",
      controller: 'coach_formationUpdate'
    })
    .when("/coach_formationDelete", {
      templateUrl: "views/pages/formation.html",
      controller: 'coach_formationDelete'
    })

    .when("/physio_fitnessCreate", {
      templateUrl: "views/pages/physio_fitnessCreateForm.html",
      controller: 'physio_fitnessCreate'
    })
    .when("/physio_fitnessRead", {
      templateUrl: "views/pages/fitness.html",
      controller: 'physio_fitnessRead'
    })
    .when("/physio_fitnessUpdate", {
      templateUrl: "views/pages/physio_fitnessCreateForm.html",
      controller: 'physio_fitnessUpdate'
    })
    .when("/physio_fitnessDelete", {
      templateUrl: "views/pages/fitness.html",
      controller: 'physio_fitnessDelete'
    })


    .when("/fixtures", {
      templateUrl: "views/pages/fixtures.html",
      controller: 'fixtures'
    })

    .when("/performance", {
      templateUrl: "views/pages/performance.html",
      controller: 'performance'
    })


    .when("/player_f", {
      templateUrl: "views/pages/players.html",
      controller: 'player_f'
    })
    .when("/player_f1", {
      templateUrl: "views/pages/players1.html",
      controller: 'player_f1'
    })
    .when("/player_f2", {
      templateUrl: "views/pages/players2.html",
      controller: 'player_f2'
    })



    .when("/player_editPassword", {
      templateUrl: "views/pages/players_loginInfo.html",
      controller: 'player_editPassword'
    })

    .when("/coach_editPassword", {
      templateUrl: "views/pages/coach_loginInfo.html",
      controller: 'coach_editPassword'
    })

    .when("/physio_editPassword", {
      templateUrl: "views/pages/physio_loginInfo.html",
      controller: 'physio_editPassword'
    })




    .otherwise({
      redirectTo: "/"
    });
  //$locationProvider.html5Mode(true);
  //$locationProvider.hashPrefix('');
  //if(window.history && window.history.pushState){
  //$locationProvider.html5Mode(true);
  //}

}]);
var app = angular.module("myApp", ["ngRoute"]);
app.config(["$routeProvider", "$locationProvider", function($routeProvider, $locationProvider) {

  $routeProvider
    .when("/", {
      templateUrl: "views/pages/index.html"
    })
    .when("/demo", {
      templateUrl: "views/pages/demopage.html",
      controller: 'demo'
    })
    .when("/player_f", {
      templateUrl: "views/pages/players.html",
      controller: 'player_f'
    })

    .when("/coach_f", {
      templateUrl: "views/pages/coach.html",
      controller: 'coach_f'
    })
    .when("/coach_f1", {
      templateUrl: "views/pages/coach1.html",
      controller: 'coach_f1'
    })
    .when("/physio_f", {
      templateUrl: "views/pages/physio.html",
      controller: 'physio_f'
    })
    .when("/admin_f", {
      templateUrl: "views/pages/admin.html",
      controller: 'admin_f'
    })

    .when("/admin_playerSearch:search", {
      templateUrl: "views/pages/playersSearchValue.html",
      controller: 'PlayerSearch'
    })

    .when("/SearchGK", {
      templateUrl: "views/pages/admin_playerGK.html",
      controller: 'admin_playerGK'
    })

    .when("/SearchCF", {
      templateUrl: "views/pages/admin_playerCF.html",
      controller: 'admin_playerCF'
    })

    .when("/SearchWingers", {
      templateUrl: "views/pages/admin_playerWingers.html",
      controller: 'admin_playerWingers'
    })

    .when("/SearchCMF", {
      templateUrl: "views/pages/admin_playerCMF.html",
      controller: 'admin_playerCMF'
    })
    .when("/SearchDMF", {
      templateUrl: "views/pages/admin_playerDMF.html",
      controller: 'admin_playerDMF'
    })
    .when("/SearchCB", {
      templateUrl: "views/pages/admin_playerCB.html",
      controller: 'admin_playerCB'
    })




    .when("/loginPlayer", {
      templateUrl: "views/pages/loginForm.html",
      controller: 'loginPlayer'
    })
    .when("/loginAdmin", {
      templateUrl: "views/pages/loginForm.html",
      controller: 'loginAdmin'
    })
    .when("/loginCoach", {
      templateUrl: "views/pages/loginForm.html",
      controller: 'loginCoach'
    })
    .when("/loginPhysio", {
      templateUrl: "views/pages/loginForm.html",
      controller: 'loginPhysio'
    })





    .when("/playerDashboard", {
      templateUrl: "views/pages/playerDashboard.html",
      controller: 'playerDashboard'
    })
    .when("/adminDashboard", {
      templateUrl: "views/pages/adminDashboard.html",
      controller: 'adminDashboard'
    })





    .when("/admin_registration", {
      templateUrl: "views/pages/admin_registrationForm.html",
      controller: 'admin_registration'
    })

    .when("/admin_coachCreate", {
      templateUrl: "views/pages/admin_coachCreateForm.html",
      controller: 'admin_coachCreate'
    })

    .when("/admin_coachUpdate:id", {
      templateUrl: "views/pages/admin_coachUpdateForm.html",
      controller: 'admin_coachUpdate'
    })
    .when("/admin_coachDelete:id", {
      templateUrl: "views/pages/coach.html",
      controller: 'admin_coachDelete'
    })
    .when("/admin_coachRead", {
      templateUrl: "views/pages/coach.html",
      controller: 'admin_coachRead'
    })




    .when("/admin_fixtureCreate", {
      templateUrl: "views/pages/admin_fixtureCreateForm.html",
      controller: 'admin_fixtureCreate'
    })
    .when("/admin_fixtureRead", {
      templateUrl: "views/pages/fixtures.html",
      controller: 'admin_fixtureRead'
    })
    .when("/admin_fixtureDelete", {
      templateUrl: "views/pages/fixtures.html",
      controller: 'admin_fixtureDelete'
    })
    .when("/admin_fixtureUpdate", {
      templateUrl: "views/pages/admin_fixtureCreateForm.html",
      controller: 'admin_fixtureUpdate'
    })



    .when("/admin_playersCreate", {
      templateUrl: "views/pages/admin_playersCreateForm.html",
      controller: 'admin_playersCreate'
    })
    .when("/admin_playerDetails:id", {
      templateUrl: "views/pages/player_details.html",
      controller: 'admin_playerDetails'
    })
    .when("/admin_playerDelete:id", {
      templateUrl: "views/pages/admin_playerDelete.html",
      controller: 'admin_playerDelete'
    })
    .when("/admin_playerUpdate:id", {
      templateUrl: "views/pages/admin_playerUpdate.html",
      controller: 'admin_playersUpdate'
    })

    .when("/admin_physioCreate", {
      templateUrl: "views/pages/admin_physioCreateForm.html",
      controller: 'admin_physioCreate'
    })
    .when("/admin_physioRead", {
      templateUrl: "views/pages/physio1.html",
      controller: 'admin_physioRead'
    })
    .when("/admin_physioDelete:id", {
      templateUrl: "views/pages/physio.html",
      controller: 'admin_physioDelete'
    })
    .when("/admin_physioUpdate:id", {
      templateUrl: "views/pages/admin_physioUpdate.html",
      controller: 'admin_physioUpdate'
    })


    .when("/admin_salaryCreate", {
      templateUrl: "views/pages/admin_salaryCreateForm.html",
      controller: 'admin_salaryCreate'
    })
    .when("/admin_salaryRead", {
      templateUrl: "views/pages/salary.html",
      controller: 'admin_salaryRead'
    })
    .when("/admin_salaryUpdate:id", {
      templateUrl: "views/pages/admin_salaryUpdateForm.html",
      controller: 'admin_salaryUpdate'
    })
    .when("/admin_salaryDelete:id", {
      templateUrl: "views/pages/salary.html",
      controller: 'admin_salaryDelete'
    })


    .when("/coach_formationCreate", {
      templateUrl: "views/pages/coach_formationCreateForm.html",
      controller: 'coach_formationCreate'
    })
    .when("/coach_formationRead", {
      templateUrl: "views/pages/formation.html",
      controller: 'coach_formationRead'
    })
    .when("/coach_formationUpdate", {
      templateUrl: "views/pages/coach_formationCreateForm.html",
      controller: 'coach_formationUpdate'
    })
    .when("/coach_formationDelete", {
      templateUrl: "views/pages/formation.html",
      controller: 'coach_formationDelete'
    })

    .when("/physio_fitnessCreate", {
      templateUrl: "views/pages/physio_fitnessCreateForm.html",
      controller: 'physio_fitnessCreate'
    })
    .when("/physio_fitnessRead", {
      templateUrl: "views/pages/fitness.html",
      controller: 'physio_fitnessRead'
    })
    .when("/physio_fitnessUpdate", {
      templateUrl: "views/pages/physio_fitnessCreateForm.html",
      controller: 'physio_fitnessUpdate'
    })
    .when("/physio_fitnessDelete", {
      templateUrl: "views/pages/fitness.html",
      controller: 'physio_fitnessDelete'
    })


    .when("/fixtures", {
      templateUrl: "views/pages/fixtures.html",
      controller: 'fixtures'
    })

    .when("/performance", {
      templateUrl: "views/pages/performance.html",
      controller: 'performance'
    })
    .when("/PerformanceRead", {
      templateUrl: "views/pages/performance1.html",
      controller: 'admin_performanceRead'
    })

    .when("/admin_PerformanceCreate", {
      templateUrl: "views/pages/admin_PerformanceCreateForm.html",
      controller: 'admin_PerformanceCreate'
    })

    .when("/admin_PerformanceUpdate:id", {
      templateUrl: "views/pages/admin_PerformanceUpdateForm.html",
      controller: 'admin_performanceUpdate'
    })
    .when("/admin_PerformanceDetails:id", {
      templateUrl: "views/pages/performanceDetails.html",
      controller: 'admin_PerformanceDetails'
    })

    .when("/admin_PerformanceDelete:id", {
      templateUrl: "views/pages/performance.html",
      controller: 'admin_PerformanceDelete'
    })




    .when("/player_f", {
      templateUrl: "views/pages/players.html",
      controller: 'player_f'
    })
    .when("/player_f1", {
      templateUrl: "views/pages/players1.html",
      controller: 'player_f1'
    })
    .when("/player_f2", {
      templateUrl: "views/pages/players2.html",
      controller: 'player_f2'
    })



    .when("/player_editPassword", {
      templateUrl: "views/pages/players_loginInfo.html",
      controller: 'player_editPassword'
    })

    .when("/coach_editPassword", {
      templateUrl: "views/pages/coach_loginInfo.html",
      controller: 'coach_editPassword'
    })

    .when("/physio_editPassword", {
      templateUrl: "views/pages/physio_loginInfo.html",
      controller: 'physio_editPassword'
    })




    .otherwise({
      redirectTo: "/"
    });
  //$locationProvider.html5Mode(true);
  //$locationProvider.hashPrefix('');
  //if(window.history && window.history.pushState){
  //$locationProvider.html5Mode(true);
  //}

}]);}]);
