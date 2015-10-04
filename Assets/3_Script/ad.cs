using UnityEngine;
using System.Collections;
using GoogleMobileAds.Api;

public class AdmobManager : MonoBehaviour {
	
	void Start () {
		BannerView banner = new BannerView("ca-app-pub-6153759682048197/6620940862", AdSize.Banner, AdPosition.Bottom);
		
		AdRequest request = new AdRequest.Builder().Build();
		
		banner.LoadAd(request);
		banner.Show();
	}
}