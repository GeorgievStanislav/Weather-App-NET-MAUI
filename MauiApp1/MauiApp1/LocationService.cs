using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1
{
    class LocationService
    {
        private CancellationTokenSource _cancelTokenSource;
        private bool _isCheckingLocation;
        public string weatherLocation;//new
        public string errorMessage;
        public bool hasLocation;

        public async Task<string> GetCachedLocation() //get last known location
        {
            try
            {
                Location location = await Geolocation.Default.GetLastKnownLocationAsync();

                if (location != null)
                {
                    weatherLocation = $"?lat={location.Latitude}&lon={location.Longitude}";
                    hasLocation = true;
                    //return $"Latitude: {location.Latitude}, Longitude: {location.Longitude}, Altitude: {location.Altitude}";
                }
                return weatherLocation;
                    
            }
            catch (FeatureNotSupportedException fnsEx)
            {
                // Handle not supported on device exception
                Debug.WriteLine(fnsEx.Message);
                Debug.WriteLine("Location is not suported!");
                errorMessage= fnsEx.Message;
                hasLocation = false;
                return errorMessage;
                throw;
            }
            catch (FeatureNotEnabledException fneEx)
            {
                // Handle not enabled on device exception
                Debug.WriteLine(fneEx.Message);
                Debug.WriteLine("Location is not enabled!");
                hasLocation = false;
                errorMessage= fneEx.Message;
                return errorMessage;
                throw;
            }
            catch (PermissionException pEx)
            {
                // Handle permission exception
                Debug.WriteLine(pEx.Message);
                Debug.WriteLine("No permission to location!");
                errorMessage= pEx.Message;
                hasLocation = false;
                return errorMessage;
                throw;
            }
            catch (Exception ex)
            {
                // Unable to get location
                Debug.WriteLine(ex.Message);
                Debug.WriteLine("Unable to get location!");
                errorMessage= ex.Message;
                hasLocation = false;
                return errorMessage;
                throw;
            }

            //return "None";
        }

        public async Task<string> GetCurrentLocation()//not static not string
        {
            try
            {
                _isCheckingLocation = true;

                GeolocationRequest request = new GeolocationRequest(GeolocationAccuracy.Lowest, TimeSpan.FromSeconds(10));

                _cancelTokenSource = new CancellationTokenSource();

                Location location = await Geolocation.Default.GetLocationAsync(request, _cancelTokenSource.Token);

                if (location != null)
                {
                    // /*Console*/Debug.WriteLine($"Latitude: {location.Latitude}, Longitude: {location.Longitude}, Altitude: {location.Altitude}");
                    weatherLocation = $"?lat={location.Latitude}&lon={location.Longitude}";//new
                    //weatherLocation += "&units=metric";//for startup
                    //weatherLocation += $"&APPID={Constants.OpenWeatherMapAPIKey}";//^ditto
                    hasLocation = true;
                }
                    return weatherLocation;//new

            }
            // Catch one of the following exceptions:
            //   FeatureNotSupportedException
            //   FeatureNotEnabledException
            //   PermissionException
            catch (FeatureNotEnabledException fneEx)
            {
                // Handle not enabled on device exception
                Debug.WriteLine(fneEx.Message);
                Debug.WriteLine("Location is not enabled!");
                hasLocation = false;
                errorMessage = fneEx.Message;
                return errorMessage;
                throw;
            }
            catch (Exception ex)
            {
                // Unable to get location
                Debug.WriteLine(ex.Message);
                Debug.WriteLine("Unable to get location");
                errorMessage= ex.Message;
                hasLocation = false;
                //weatherLocation = ex.Message;
                //await DisplayAlert("Alert", "You have been alerted", "OK");
                return errorMessage;
                throw;
            }
            finally
            {
                _isCheckingLocation = false;
            }
        }

        public void CancelRequest()
        {
            if (_isCheckingLocation && _cancelTokenSource != null && _cancelTokenSource.IsCancellationRequested == false)
                _cancelTokenSource.Cancel();
        }
    }
}
