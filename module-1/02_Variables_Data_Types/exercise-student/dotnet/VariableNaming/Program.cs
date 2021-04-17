namespace VariableNaming
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            1. 4 birds are sitting on a branch. 1 flies away. How many birds are left on
            the branch?
            */

            // ### EXAMPLE:
            int initialNumberOfBirds = 4;
            int birdsThatFlewAway = 1;
            int remainingNumberOfBirds = initialNumberOfBirds - birdsThatFlewAway;

            /*
            2. There are 6 birds and 3 nests. How many more birds are there than
            nests?
            */

            // ### EXAMPLE:
            int numberOfBirds = 6;
            int numberOfNests = 3;
            int numberOfExtraBirds = numberOfBirds - numberOfNests;



            /*
            3. 3 raccoons are playing in the woods. 2 go home to eat dinner. How
            many raccoons are left in the woods?
            */

            int raccoonsPlaying = 3;
            int raccoonsGoHome = 2;
            int raccoonsStillPlaying = raccoonsPlaying - raccoonsGoHome;

            /*
            4. There are 5 flowers and 3 bees. How many less bees than flowers?
            */

            int flowers = 5;
            int bees = 3;
            int lessBeesThanFlowers = flowers - bees;

            /*
            5. 1 lonely pigeon was eating breadcrumbs. Another pigeon came to eat
            breadcrumbs, too. How many pigeons are eating breadcrumbs now?
            */

            int lonelyPigeon = 1;
            int joinerPigeon = 1;
            int totalPigeonsEating = lonelyPigeon + joinerPigeon;

            /*
            6. 3 owls were sitting on the fence. 2 more owls joined them. How many
            owls are on the fence now?
            */

            int sittingOwls = 3;
            int joinerOwls = 2;
            int totalOwlsSitting = sittingOwls + joinerOwls;

            /*
            7. 2 beavers were working on their home. 1 went for a swim. How many
            beavers are still working on their home?
            */

            int beaversWorking = 2;
            int beaversSwimming = 1;
            int beaversStillWorking = beaversWorking - beaversSwimming;

            /*
            8. 2 toucans are sitting on a tree limb. 1 more toucan joins them. How
            many toucans in all?
            */

            int initialToucans = 2;
            int joinerToucan = 1;
            int totalToucans = initialToucans + joinerToucan;

            /*
            9. There are 4 squirrels in a tree with 2 nuts. How many more squirrels
            are there than nuts?
            */

            int squirrels = 4;
            int nuts = 2;
            int differenceOfSquirrelsAndNuts = squirrels - nuts;

            /*
            10. Mrs. Hilt found a quarter, 1 dime, and 2 nickels. How much money did
            she find?
            */

            decimal quarter = .25M;
            decimal dime = .10M;
            decimal nickel = .05M;
            decimal foundMoney = quarter + dime + (nickel * 2);

            /*
            11. Mrs. Hilt's favorite first grade classes are baking muffins. Mrs. Brier's
            class bakes 18 muffins, Mrs. MacAdams's class bakes 20 muffins, and
            Mrs. Flannery's class bakes 17 muffins. How many muffins does first
            grade bake in all?
            */

            int brierMuffins = 18;
            int macadamsMuffins = 20;
            int flanneryMuffins = 17;
            int firstGradeMuffins = brierMuffins + macadamsMuffins + flanneryMuffins;

            /*
            12. Mrs. Hilt bought a yoyo for 24 cents and a whistle for 14 cents. How
            much did she spend in all for the two toys?
            */

            decimal yoyoCost = .24M;
            decimal whistleCost = .14M;
            decimal toyCost = yoyoCost + whistleCost;

            /*
            13. Mrs. Hilt made 5 Rice Krispie Treats. She used 8 large marshmallows
            and 10 mini marshmallows. How many marshmallows did she use
            altogether?
            */

            int largeMarshmallows = 8;
            int miniMarshmallows = 10;
            int totalMarshmallows = largeMarshmallows + miniMarshmallows;

            /*
            14. At Mrs. Hilt's house, there was 29 inches of snow, and Brecknock
            Elementary School received 17 inches of snow. How much more snow
            did Mrs. Hilt's house have?
            */

            int houseSnow = 29;
            int schoolSnow = 17;
            int differenceSnow = houseSnow - schoolSnow;

            /*
            15. Mrs. Hilt has $10. She spends $3 on a toy truck and $2 on a pencil
            case. How much money does she have left?
            */

            decimal hiltWalletStart = 10M;
            decimal toyTruckCost = 3M;
            decimal pencilCaseCost = 2M;
            decimal hiltWalletEnd = hiltWalletStart - toyTruckCost - pencilCaseCost;

            /*
            16. Josh had 16 marbles in his collection. He lost 7 marbles. How many
            marbles does he have now?
            */

            int marblesStart = 16;
            int marblesLost = 7;
            int marblesEnd = marblesStart - marblesLost;

            /*
            17. Megan has 19 seashells. How many more seashells does she need to
            find to have 25 seashells in her collection?
            */

            int seashellsStart = 19;
            int seashellsWanted = 25;
            int seashellsToFind = seashellsWanted - seashellsStart;

            /*
            18. Brad has 17 balloons. 8 balloons are red and the rest are green. How
            many green balloons does Brad have?
            */

            int totalBalloons = 17;
            int redBalloons = 8;
            int greenBalloons = totalBalloons - redBalloons;

            /*
            19. There are 38 books on the shelf. Marta put 10 more books on the shelf.
            How many books are on the shelf now?
            */

            int booksStart = 38;
            int booksAdded = 10;
            int bookShelfUpdated = booksStart + booksAdded;

            /*
            20. A bee has 6 legs. How many legs do 8 bees have?
            */

            int beeLegs = 6;
            int totalLegs = beeLegs * 8;

            /*
            21. Mrs. Hilt bought an ice cream cone for 99 cents. How much would 2 ice
            cream cones cost?
            */

            decimal singleCone = 0.99M;
            decimal twoCones = singleCone * 2M;

            /*
            22. Mrs. Hilt wants to make a border around her garden. She needs 125
            rocks to complete the border. She has 64 rocks. How many more rocks
            does she need to complete the border?
            */

            int rockStartValue = 64;
            int rocksTotalValue = 125;
            int rocksNeeded = rocksTotalValue - rockStartValue;

            /*
            23. Mrs. Hilt had 38 marbles. She lost 15 of them. How many marbles does
            she have left?
            */

            int hiltMarbleStart = 38;
            int hiltMarbleLost = 15;
            int hiltMarbleEnd = hiltMarbleStart - hiltMarbleLost;

            /*
            24. Mrs. Hilt and her sister drove to a concert 78 miles away. They drove 32
            miles and then stopped for gas. How many miles did they have left to drive?
            */

            int concertDistance = 78;
            int milesToGasStation = 32;
            int milesLeftToConcert = concertDistance - milesToGasStation;

            /*
            25. Mrs. Hilt spent 1 hour and 30 minutes shoveling snow on Saturday
            morning and 45 minutes shoveling snow on Saturday afternoon. How
            much total time (in minutes) did she spend shoveling snow?
            */

            int satMornShovelingTime = 90;
            int satAftShovelingTime = 45;
            int satTotalShovelingTime = satMornShovelingTime + satAftShovelingTime;

            /*
            26. Mrs. Hilt bought 6 hot dogs. Each hot dog cost 50 cents. How much
            money did she pay for all of the hot dogs?
            */

            int hotdogsPurchased = 6;
            decimal hotdogCost = .50M;
            decimal moneySpentOnHotdogs = hotdogsPurchased * hotdogCost;

            /*
            27. Mrs. Hilt has 50 cents. A pencil costs 7 cents. How many pencils can
            she buy with the money she has?
            */

            decimal hiltStartingMoney = .50M;
            decimal pencilCost = .07M;
            int pencilsCanBuy = (int)(hiltStartingMoney / pencilCost);

            /*
            28. Mrs. Hilt saw 33 butterflies. Some of the butterflies were red and others
            were orange. If 20 of the butterflies were orange, how many of them
            were red?
            */

            int butterfliesSeenTotal = 33;
            int butterfliesOrange = 20;
            int butterfilesRed = butterfliesSeenTotal - butterfliesOrange;

            /*
            29. Kate gave the clerk $1.00. Her candy cost 54 cents. How much change
            should Kate get back?
            */

            decimal givenToClerk = 1.0M;
            decimal candyCost = 0.54M;
            decimal changeBack = givenToClerk - candyCost;

            /*
            30. Mark has 13 trees in his backyard. If he plants 12 more, how many trees
            will he have?
            */

            int markYardTreesInit = 13;
            int markYardTreesToPlant = 12;
            int markYardTreesFinal = markYardTreesInit + markYardTreesToPlant;

            /*
            31. Joy will see her grandma in two days. How many hours until she sees
            her?
            */

            int daysUntilGrandma = 2;
            int hoursInDay = 24;
            int hoursUntilGrandma = daysUntilGrandma * hoursInDay;

            /*
            32. Kim has 4 cousins. She wants to give each one 5 pieces of gum. How
            much gum will she need?
            */

            int kimHasCousins = 4;
            int gumToGive = 5;
            int gumPiecesNeeded = kimHasCousins * gumToGive;

            /*
            33. Dan has $3.00. He bought a candy bar for $1.00. How much money is
            left?
            */

            decimal danHasMoney = 3.00M;
            decimal danCandyBarCost = 1.00M;
            decimal danHasLeft = danHasMoney - danCandyBarCost;

            /*
            34. 5 boats are in the lake. Each boat has 3 people. How many people are
            on boats in the lake?
            */

            int boatsInLake = 5;
            int peoplePerBoat = 3;
            int peopleOnBoatsInLake = boatsInLake * peoplePerBoat;

            /*
            35. Ellen had 380 legos, but she lost 57 of them. How many legos does she
            have now?
            */

            int ellenLegosStart = 380;
            int ellenLegosLost = 57;
            int ellenLegosEnd = ellenLegosStart - ellenLegosLost;

            /*
            36. Arthur baked 35 muffins. How many more muffins does Arthur have to
            bake to have 83 muffins?
            */

            int arthurMuffins = 35;
            int totalMuffinsWanted = 83;
            int stillNeededMuffins = totalMuffinsWanted - arthurMuffins;

            /*
            37. Willy has 1400 crayons. Lucy has 290 crayons. How many more
            crayons does Willy have then Lucy?
            */

            int willyCrayons = 1400;
            int lucyCrayons = 290;
            int willyHasMore = willyCrayons - lucyCrayons;

            /*
            38. There are 10 stickers on a page. If you have 22 pages of stickers, how
            many stickers do you have?
            */

            int stickersPerPage = 10;
            int totalPages = 22;
            int totalStickers = stickersPerPage * totalPages;

            /*
            39. There are 96 cupcakes for 8 children to share. How much will each
            person get if they share the cupcakes equally?
            */

            int totalCupcakes = 96;
            int hungryChildren = 8;
            decimal cupcakesPerChild = (decimal)totalCupcakes / hungryChildren;

            /*
            40. She made 47 gingerbread cookies which she will distribute equally in
            tiny glass jars. If each jar is to contain six cookies each, how many
            cookies will not be placed in a jar?
            */

            int gingerbreadCookies = 47;
            int cookiesPerJar = 6;
            int cookiesLeftOverForMeToEat = gingerbreadCookies % cookiesPerJar;

            /*
            41. She also prepared 59 croissants which she plans to give to her 8
            neighbors. If each neighbor received and equal number of croissants,
            how many will be left with Marian?
            */

            int croissantsPrepared = 59;
            int numOfNeighbors = 8;
            int leftoverCroissants = croissantsPrepared % numOfNeighbors;

            /*
            42. Marian also baked oatmeal cookies for her classmates. If she can
            place 12 cookies on a tray at a time, how many trays will she need to
            prepare 276 oatmeal cookies at a time?
            */

            int cookiesToBakeAtOnce = 276;
            int cookiesPerTray = 12;
            int traysNeeded = cookiesToBakeAtOnce / cookiesPerTray;

            /*
            43. Marian’s friends were coming over that afternoon so she made 480
            bite-sized pretzels. If one serving is equal to 12 pretzels, how many
            servings of bite-sized pretzels was Marian able to prepare?
            */

            int pretzelsMade = 480;
            int pretzelServingSize = 12;
            int totalServings = pretzelsMade / pretzelServingSize;

            /*
            44. Lastly, she baked 53 lemon cupcakes for the children living in the city
            orphanage. If two lemon cupcakes were left at home, how many
            boxes with 3 lemon cupcakes each were given away?
            */

            int lemonCupcakesBaked = 53;
            int lemonCupcakesLeftAtHome = 2;
            int lemonCupcakesPerBox = 3;
            int boxesOfCupcakesGivenAway = (lemonCupcakesBaked - lemonCupcakesLeftAtHome) / lemonCupcakesPerBox;

            /*
            45. Susie's mom prepared 74 carrot sticks for breakfast. If the carrots
            were served equally to 12 people, how many carrot sticks were left
            uneaten?
            */

            int carrotSticksPrepared = 74;
            int weirdPeopleEatingCarrotsForBreakfast = 12;
            int carrotSticksLeftUneaten = carrotSticksPrepared % weirdPeopleEatingCarrotsForBreakfast;

            /*
            46. Susie and her sister gathered all 98 of their teddy bears and placed
            them on the shelves in their bedroom. If every shelf can carry a
            maximum of 7 teddy bears, how many shelves will be filled?
            */

            int totalTeddyBears = 98;
            int teddyBearsPerShelf = 7;
            int shelvesNeeded = totalTeddyBears / teddyBearsPerShelf;

            /*
            47. Susie’s mother collected all family pictures and wanted to place all of
            them in an album. If an album can contain 20 pictures, how many
            albums will she need if there are 480 pictures?
            */

            int totalPictures = 480;
            int picturesPerAlbum = 20;
            int albumsNeededForPictures = totalPictures / picturesPerAlbum;

            /*
            48. Joe, Susie’s brother, collected all 94 trading cards scattered in his
            room and placed them in boxes. If a full box can hold a maximum of 8
            cards, how many boxes were filled and how many cards are there in
            the unfilled box?
            */

            int scatteredCardsTotal = 94;
            int cardsPerBox = 8;
            int filledCardBoxes = scatteredCardsTotal / cardsPerBox;
            int cardsInUnfilledBox = scatteredCardsTotal % cardsPerBox;

            /*
            49. Susie’s father repaired the bookshelves in the reading room. If he has
            210 books to be distributed equally on the 10 shelves he repaired,
            how many books will each shelf contain?
            */

            int booksInTotal = 210;
            int shelvesBuilt = 10;
            int booksPerShelf = booksInTotal / shelvesBuilt;

            /*
            50. Cristina baked 17 croissants. If she planned to serve this equally to
            her seven guests, how many will each have?
            */

            int bakedCroissants = 17;
            int sevenGuests = 7;
            double croissantsPerGuest = (double)bakedCroissants / (double)sevenGuests;

            /*
            51. Bill and Jill are house painters. Bill can paint a 12 x 14 room in 2.15 hours, while Jill averages
            1.90 hours. How long will it take the two painters working together to paint 5 12 x 14 rooms?
            Hint: Calculate the hourly rate for each painter, combine them, and then divide the total walls in feet by the combined hourly rate of the painters.
            */

            double numberOfRooms = 5D;
            double roomLength = 12D;
            double roomWidth = 14D;
            double billPaintSpeed = (roomLength * roomWidth) / 2.15D;
            double jillPaintSpeed = (roomLength * roomWidth) / 1.90D;
            double combinedPaintTime = ((roomLength * roomWidth) * numberOfRooms) / (billPaintSpeed + jillPaintSpeed);

            /*
            52. Create and assign variables to hold a first name, last name, and middle initial. Using concatenation,
            build an additional variable to hold the full name in the order of last name, first name, middle initial. The
            last and first names should be separated by a comma followed by a space, and the middle initial must end
            with a period. Use "Grace", "Hopper, and "B" for the first name, last name, and middle initial.
            Example: "John", "Smith, "D" —> "Smith, John D."
            */

            string firstName = "Grace";
            string lastName = "Hopper";
            string middleInitial = "B";
            string commaSpace = ", ";
            string addSpace = " ";
            string addPeriod = ".";
            string fullName = lastName + commaSpace + firstName + addSpace + middleInitial + addPeriod;

            /*
            53. The distance between New York and Chicago is 800 miles, and the train has already travelled 537 miles.
            What percentage of the trip as a whole number (integer) has been completed?
            */

            double cityDistance = 800D;
            double alreadyTravelled = 537D;
            double travelPercentageAsDouble = (alreadyTravelled / cityDistance) * 100;
            int travelPercentageAsInt = (int)travelPercentageAsDouble;
        }
    }
}
