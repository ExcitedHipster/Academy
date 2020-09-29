select SourceUserName , DestinationUserName , Amount
from Transactions
where amount>100 and SourceUserName= 'Daniel'