Silas
=====

##Forecasting of Website Traffic using SignalR and WebAPI

Forecasting data, whether it be website traffic or retail sales, is considered by many to be a black box system built on advanced statistical models that are incomprehensible.  With the proliferation of dynamic infrastructures through services like Amazon Web Services, the ability to predict resource utilization becomes more important than ever.  A predictive infrastructure system creates an enormous advantage by reducing wasted resources.  This talk lays the groundwork for building a forecasting system of website traffic.  The traffic results will be loaded into the system through a RESTful service built with ASP.NET WebAPI.  The system will update predictions through a custom forecasting system.  Finally, the results of the forecast will be sent to a client side charting framework utilizing SignalR.  There will be a comparison and contrast of four different forecasting models and discussions of which forecasting techniques will help the most with varying types of data.  The four forecasting models will include moving average, single, double, and triple exponential smoothing.  The number one rule of forecasting is that your forecast will always be wrong; thus, an analysis of when and how to use confidence intervals will be provided.

##Roadmap
1. Allow dynamic analysis of data to choose correct method.
2. Generate best parameters on the fly.
3. Add in Confidence Intervals
4. Add in Holdout data.
5. Package better for easier reuse.
6. Use official .NET dashing framework? 