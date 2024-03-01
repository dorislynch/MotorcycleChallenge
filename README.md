
# react-native-motorcycle-challenge

## Getting started

`$ npm install react-native-motorcycle-challenge --save`

### Mostly automatic installation

`$ react-native link react-native-motorcycle-challenge`

### Manual installation


#### iOS

1. In XCode, in the project navigator, right click `Libraries` ➜ `Add Files to [your project's name]`
2. Go to `node_modules` ➜ `react-native-motorcycle-challenge` and add `RNMotorcycleChallenge.xcodeproj`
3. In XCode, in the project navigator, select your project. Add `libRNMotorcycleChallenge.a` to your project's `Build Phases` ➜ `Link Binary With Libraries`
4. Run your project (`Cmd+R`)<

#### Android

1. Open up `android/app/src/main/java/[...]/MainActivity.java`
  - Add `import com.reactlibrary.RNMotorcycleChallengePackage;` to the imports at the top of the file
  - Add `new RNMotorcycleChallengePackage()` to the list returned by the `getPackages()` method
2. Append the following lines to `android/settings.gradle`:
  	```
  	include ':react-native-motorcycle-challenge'
  	project(':react-native-motorcycle-challenge').projectDir = new File(rootProject.projectDir, 	'../node_modules/react-native-motorcycle-challenge/android')
  	```
3. Insert the following lines inside the dependencies block in `android/app/build.gradle`:
  	```
      compile project(':react-native-motorcycle-challenge')
  	```

#### Windows
[Read it! :D](https://github.com/ReactWindows/react-native)

1. In Visual Studio add the `RNMotorcycleChallenge.sln` in `node_modules/react-native-motorcycle-challenge/windows/RNMotorcycleChallenge.sln` folder to their solution, reference from their app.
2. Open up your `MainPage.cs` app
  - Add `using Motorcycle.Challenge.RNMotorcycleChallenge;` to the usings at the top of the file
  - Add `new RNMotorcycleChallengePackage()` to the `List<IReactPackage>` returned by the `Packages` method


## Usage
```javascript
import RNMotorcycleChallenge from 'react-native-motorcycle-challenge';

// TODO: What to do with the module?
RNMotorcycleChallenge;
```
  