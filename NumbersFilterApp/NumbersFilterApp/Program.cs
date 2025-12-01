using NumbersFilterApp;

var numbers = NumberService.ReadNumbersFromUser();
var filtered = NumberService.FilterNumbers(numbers);
NumberService.PrintNumbers(filtered);