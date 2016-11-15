var newApp = angular.module('MyApp', ['ngResource', 'ngRoute']);

newApp.factory('CountryService', ['$http', '$q', '$resource', function ($http, $q, $resource) {
    return $resource('/Scripts/Create');
}]);
newApp.factory('ScriptService', ['$http', '$q', '$resource', function ($http, $q, $resource) {
    return $resource('/Scripts/ReadXMLScript', {}, { isArray: true });
}]);