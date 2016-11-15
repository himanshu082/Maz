newApp.controller('MyCtrl', ['$scope', '$compile', '$resource', '$http', 'CountryService', 'ScriptService', function ($scope, $compile, $resource, $http, CountryService, ScriptService) {

    $("#site").change(function (site) {
        $('#pName').val('');
        $('#tName').val('');
        $('#createdby').val('');
        var test = $('#site').val();
        $.ajax({
            url: '/Scripts/GetLanguagesByCountry',
            type: 'POST',
            dataType: 'JSON',
            data: { country: test },
            success: function (result) {
                $('#languageResponse').val(result);
                $scope.lName = result;
            }
        });
    });

    $scope.site = "";
    //$scope.lName = "";
    $scope.pName = "";
    $scope.tName = "";
    $scope.createdby = "";
    $scope.finalResponse = "";

    $scope.saveScript = function () {
        $scope.scriptDTO = { SiteCountry: $scope.site, SelectedLanguages: $scope.lName, PageName: $scope.pName, TagName: $scope.tName, CreatedBy: $scope.createdby };
        CountryService.save($scope.scriptDTO, function (response) {
            $scope.responseMSG = response.message;
            alert(JSON.stringify($scope.responseMSG));
        });
    }
    $scope.readScript = function () {
        ScriptService.save(function (response) {
            $scope.message = response.message;
            alert(JSON.stringify($scope.message));
        });
    }
}]);