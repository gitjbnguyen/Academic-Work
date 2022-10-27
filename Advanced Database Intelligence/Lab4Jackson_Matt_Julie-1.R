#import tidyverse or ggplot
library(ggplot2)
#using "airquality" which is built in to R studio
data("airquality") 
str(airquality)
#show first 3 data points in set (changing n will show more rows)
head(airquality, n=3)
#show last 5 data points in set
tail(airquality, n=5)

#begin data visualization
plot(airquality$Ozone)

#break the data up by month
airquality$Month <- factor(airquality$Month)

ggplot(airquality, aes(Ozone, Temp))+ #sets data set and sets axis
  geom_point(color = "steelblue", size = 3, alpha = .5)+#sets color and shading of dots
  facet_grid(.~Month)+#splits data into months and each is its own graph for comparison
  geom_smooth(method = "lm")# And finally we add a linear model 
#to each facet of the plot in order to get an idea of the trend 
#within that month's data. 
#The grey area around the trend is the confidence interval 
#of the band; where it is widest, there are few data points 
#and so the band displays a relative degree of uncertainty about 
#the accuracy of the line.

ggplot(airquality, aes(Wind, Ozone))+#set to ozone and wind to see if there is correlation
  geom_point(colour = "red",, size = 5, alpha = .5)+
  geom_smooth(method = "lm")
#there is a very strong correlation that wind 
#speed has an effect on Ozone creation at ground level


#set ozone to square root
airquality$Ozone.sqrt <- sqrt(airquality$Ozone)
qplot(Temp, Ozone.sqrt, data=airquality, color = Month, geom="point")


# CLEAN UP #################################################

# Clear workspace
rm(list = ls()) 

# Clear packages
pacman::p_unload(arules, arulesViz)

# Clear plots
dev.off()

# Clear console
cat("\014")  # ctrl+L
#Webpages I used to figure out the code and what it shows
#https://towardsdatascience.com/a-guide-to-data-visualisation-in-r-for-beginners-ef6d41a34174
#http://rstudio-pubs-static.s3.amazonaws.com/84231_884be55de6d74808a2568dca7e329b6c.html
#https://rpubs.com/shailesh/air-quality-exploration

