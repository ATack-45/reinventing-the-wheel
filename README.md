# Utility Package
This is a repository of tools made to convinently do simple tasks such as simple artithmitic, word transformations and array sorting to name a few. This package was created to easily integrate into projects via NuGet to deliver a convient and simple way to do a variety of simple tasks under a MIT licence.

## String Examples
### ToUpper
this method takes in a string and returns a all upercase version of it
#### Example
  `StringUtils.ToUpper("the")` would output -> `THE`

### ToLower
this method takes in a string and returns a all lowercase version of it
#### Example
  `StringUtils.ToLower("THE")` would output -> `the`

### Length
this method takes in a string and returns the length in number of charecters of it
#### Example
  `StringUtils.Length("the")` would output -> `3`

### Reverse
this method takes in a string and returns a reversed version of it
#### Example
  `StringUtils.Reverse("the")` would output -> `eth`

### CountVowels
this method takes in a string and returns the number of vowels in it
#### Example
  `StringUtils.CountVowels("the")` would output -> `1`

### Count Consonants
this method takes in a string and returns how many consonants in it
#### Example
  `StringUtils.Consonants("the")` would output -> `2`

  ### HasLetter
this method takes in a string and a charecter and returns a boolean condition whether or not the charecher is in the string
#### Example
  `StringUtils.HasLetter("the", 'e)` would output -> `true`

### ToCharArray
this method takes in a string and returns a array of charecter matching the charechers in the string
#### Example
  `StringUtils.ToCharArray("the")` would output -> `['t','h','e']`

### Trim
this method takes in a string and trims all of the whitespace off of it
#### Example
  `StringUtils.Trim("  the   ")` would output -> `the`

  ### Append
this method takes in two strings and combines them to return a single string
#### Example
  `StringUtils.Append("the", " cow")` would output -> `the cow`

### GetCharNum
this method takes in a charecter and returns its representitive number
#### Example
  `StringUtils.GetCharNum('t)` would output -> `20`

### GetNumChar
this method takes in a number and returns its representititive charecter
#### Example
  `StringUtils.GetNumChar(20)` would output -> `t`

  ### Encode
this method takes in a string and returns a array of integers that represent a charecter in the code
#### Example
  `StringUtils.Encode("the")` would output -> `[35,23,20]`

### Decode
this method takes in a encoded array from the previous method and decoded it by the same code (will only decode from the previous method)
#### Example
  `StringUtils.Decode([35,23,20])` would output -> `the`


