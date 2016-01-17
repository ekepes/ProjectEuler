'''
1 Jan 1900 was a Monday.
Thirty days has September,
April, June and November.
All the rest have thirty-one,
Saving February alone,
Which has twenty-eight, rain or shine.
And on leap years, twenty-nine.
A leap year occurs on any year evenly divisible by 4, but not on a century unless it is divisible by 400.
How many Sundays fell on the first of the month during the twentieth century (1 Jan 1901 to 31 Dec 2000)?
'''

'''
Sunday = 0, Monday = 1, etc.
'''
monthDays = [31, -1, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31]

dayCount = 2
sundayOnTheFirstCount = 0
for year in range(1901, 2001):
  for month in range(12):
    if dayCount % 7 == 0:
      sundayOnTheFirstCount += 1
    addDays = monthDays[month]
    if addDays == -1:
      if year % 4 == 0:
        addDays = 29
      else:
        addDays = 28
    dayCount += addDays

print(sundayOnTheFirstCount)