using System.Reflection.Metadata.Ecma335;

namespace Day7
{
    internal enum HandType
    {
        HighCard = 0,
        OnePair = 1,
        TwoPair = 2,
        ThreeOfAKind = 3,
        FullHouse = 4,
        FourOfAKind = 5,
        FiveOfAKind = 6,
    }

    internal class Hand
    {
        public Dictionary<char, int> cardCounts;
        public string handCards;
        public int bet;
        public int jackCount;
        public HandType type;

        public Hand(string handBet, bool jacksWild = false)
        {
            cardCounts = new Dictionary<char, int>();
            string[] handAndBet = handBet.Split(" ");
            handCards = handAndBet[0];
            bet = int.Parse(handAndBet[1]);
            jackCount = 0;

            foreach (char card in handCards)
            {
                if(jacksWild && card == 'J')
                {
                    jackCount += 1;
                    continue;
                }

                if (!cardCounts.ContainsKey(card))
                {
                    cardCounts[card] = 0;
                }

                cardCounts[card] += 1;
            }

            type = GetHandType(jackCount);
        }

        public override string ToString()
        {

            return string.Format("Type: {0} Hand: {1} Bet:{2}", type, handCards, bet);
        }

        private HandType GetHandType(int jackCount = 0)
        {
            // If only one non-jack card type or only jacks are found, it's five of a kind
            if(cardCounts.Count <= 1)
            {
                return HandType.FiveOfAKind;
            }

            // 3 Jacks or more allows four of a kind
            if(jackCount > 2)
            {
                return HandType.FourOfAKind;
            }
            if(jackCount == 2)
            {
                if(cardCounts.Count == 3)
                {
                    return HandType.ThreeOfAKind;
                }
                return HandType.FourOfAKind;
            }
            if(jackCount == 1)
            {
                if(cardCounts.Count == 4)
                {
                    return HandType.OnePair;
                }
                if (cardCounts.Count == 3)
                {
                    return HandType.ThreeOfAKind;
                }
                if(cardCounts[cardCounts.Keys.First()] == 2)
                {
                    return HandType.FullHouse;
                }
                return HandType.FourOfAKind;
            }
            
            // No jacks logic
            if (cardCounts.Count == 5)
            {
                return HandType.HighCard;
            }
            if (cardCounts.Count == 4)
            {
                return HandType.OnePair;
            }

            int checkCount = cardCounts[cardCounts.Keys.First()];

            // Either Full House or Four of a kind
            if (cardCounts.Count == 2)
            {
                if (checkCount == 1 || checkCount == 4)
                {
                    return HandType.FourOfAKind;
                }
                return HandType.FullHouse;
            }

            // Either three of a kind or two pair
            if (checkCount == 1)
            {
                checkCount = cardCounts[cardCounts.Keys.Last()];
            }
            if (checkCount == 2)
            {
                return HandType.TwoPair;
            }

            return HandType.ThreeOfAKind;
        }
    }
    internal class HandComparer : IComparer<Hand>
    {
        private Dictionary<char, int> cardToValue = new Dictionary<char, int>
        {
            { '2', 0 },
            { '3', 1 },
            { '4', 2 },
            { '5', 3 },
            { '6', 4 },
            { '7', 5 },
            { '8', 6 },
            { '9', 7 },
            { 'T', 8 },
            { 'J', 9 },
            { 'Q', 10 },
            { 'K', 11 },
            { 'A', 12 },
        };

        public HandComparer(bool jacksWild = false)
        {
            if(jacksWild)
            {
                Console.Write("Jacks Wild!");
                cardToValue['J'] = -1;
            }
        }

        public int Compare(Hand x, Hand y)
        {
            if (x.type > y.type)
            {
                return 1;
            }
            if (x.type < y.type)
            {
                return -1;
            }

            for (int i = 0; i < x.handCards.Length; i += 1)
            {
                if (cardToValue[x.handCards[i]] > cardToValue[y.handCards[i]])
                {
                    return 1;
                }
                if (cardToValue[x.handCards[i]] < cardToValue[y.handCards[i]])
                {
                    return -1;
                }
            }

            return 0;
        }
    }
    public class Program
    {
        private static void Part1(string[] hands)
        {
            int accum = 0;
            SortedSet<Hand> sortedHands = new SortedSet<Hand>(new HandComparer());

            foreach (string h in hands)
            {
                sortedHands.Add(new Hand(h));
            }

            for (int i = 0; i < sortedHands.Count; i += 1)
            {
                accum += (i + 1) * sortedHands.ElementAt(i).bet;
            }

            Console.WriteLine(accum);
        }

        private static void Part2(string[] hands)
        {
            int accum = 0;
            SortedSet<Hand> sortedHands = new SortedSet<Hand>(new HandComparer(true));

            foreach (string h in hands)
            {
                sortedHands.Add(new Hand(h, true));
            }

            for (int i = 0; i < sortedHands.Count; i += 1)
            {
                Console.WriteLine(sortedHands.ElementAt(i));
                accum += (i + 1) * sortedHands.ElementAt(i).bet;
            }

            Console.WriteLine(accum);
        }

        public static void Main()
        {
            const string puzzleInput = "49A49 734\r\n67594 467\r\nQ2429 453\r\n3J787 359\r\nK4824 703\r\n29992 804\r\n94JQK 988\r\n2TQT5 765\r\n7TQ3T 710\r\nJ4389 979\r\n96J56 271\r\nJTTJT 488\r\n7QA5J 306\r\nQ72Q2 163\r\nA666A 759\r\n2779T 566\r\nA777Q 136\r\nTJ277 365\r\nQQ339 388\r\nKA22K 31\r\n99974 590\r\n72672 946\r\n4T25A 423\r\n38873 650\r\n97Q99 26\r\n36436 66\r\n98979 230\r\nTTTK8 44\r\nQQAQ4 451\r\n77774 668\r\nT77QT 108\r\nJAJJA 681\r\n74T52 637\r\n9A7TA 843\r\n4A334 3\r\n669KK 727\r\n999A6 156\r\n77T77 464\r\n845J3 59\r\nAAAQQ 933\r\n38K88 806\r\n2QQ2J 107\r\nTJATT 936\r\n44737 794\r\n66J66 33\r\nT4TJQ 106\r\n74TTQ 97\r\nK84J4 374\r\n55AAA 805\r\nKK3K3 513\r\n33393 178\r\n4J44J 328\r\n682A5 728\r\nAJTKT 249\r\n6959K 363\r\n9993Q 991\r\nK2K3T 70\r\nJJQ42 857\r\nAJ888 419\r\n47T62 393\r\n66JTT 498\r\n44474 539\r\n37QTA 747\r\nQQ4JT 473\r\nJ6JQQ 678\r\n5TT55 538\r\nJ22A2 15\r\nQTAA9 478\r\n7K43J 410\r\nTKT2A 368\r\n8KKK8 332\r\nKK686 771\r\n47762 550\r\nJ3773 653\r\n557J5 167\r\n8388T 926\r\nJ77K4 309\r\n3A9Q5 215\r\nA6AA2 845\r\nK55KK 499\r\nK8239 238\r\nTA6AA 987\r\nAA2AA 413\r\n9628A 81\r\nA22AK 50\r\n75565 141\r\nTT56T 518\r\n2A52J 816\r\n444J3 690\r\nT3565 582\r\nA33J3 258\r\n42877 96\r\n99J99 444\r\n4A234 572\r\nJT5K8 929\r\n74QT5 852\r\nJ25J4 76\r\n5Q588 853\r\n74T24 1\r\nA7853 16\r\n4T53T 646\r\n9KT7Q 511\r\n376A7 781\r\n66496 944\r\n6J737 839\r\n767J6 386\r\n62A65 963\r\n8A8A3 246\r\n255TT 429\r\n58J8A 341\r\n37828 279\r\nT3598 30\r\n68JK8 109\r\n89247 883\r\nQJ557 510\r\nTA899 656\r\n6K6KJ 714\r\n3667J 102\r\nJAAAT 821\r\n38JAK 748\r\n778A7 411\r\nK93JK 463\r\nA85T2 80\r\n8T39A 495\r\n3JT3T 203\r\nK9K5K 721\r\n9J9J9 679\r\n4Q5Q4 101\r\n37333 745\r\n999QQ 943\r\n84484 25\r\n28268 469\r\n33TAA 99\r\nKAJKJ 924\r\nT4JJ3 185\r\n6777K 725\r\n33J9K 846\r\nJ7577 899\r\n48K45 575\r\nTK852 104\r\n97737 161\r\n65552 738\r\n33TTT 915\r\n2AJ47 644\r\n288Q2 870\r\n85599 159\r\n997AQ 552\r\nJ6879 117\r\n6TJ96 820\r\n45K62 674\r\n9ATAT 537\r\n9K7Q2 211\r\nKKKAK 620\r\n7TT6T 837\r\nTT444 865\r\n5K8KK 195\r\nKK6K6 170\r\nJ2888 744\r\n8A228 40\r\nTT9K9 334\r\n5998Q 992\r\nKJ964 760\r\nKKK98 460\r\n8J444 917\r\nTK9A8 485\r\nT8KK5 216\r\n6TA6Q 871\r\nTA39K 461\r\nJ9QK5 292\r\n2222T 751\r\n697KT 524\r\n5565J 484\r\nT6T3T 241\r\n696A6 542\r\n5QQ53 531\r\n75555 639\r\n299J2 219\r\nA5552 882\r\n33AAJ 224\r\n49494 455\r\nKJ635 532\r\n92QJ8 397\r\nJ3333 990\r\n58955 739\r\n89888 822\r\n93233 521\r\nJ6444 599\r\n95TT5 351\r\nT3333 62\r\n385K9 217\r\n35AKJ 682\r\n53222 889\r\nTT35T 591\r\n87QJ7 196\r\n45226 261\r\n65K7A 717\r\n99J6K 137\r\n77757 73\r\n88J97 800\r\nJ6335 142\r\n3A3K3 231\r\n75Q5Q 311\r\n3J265 574\r\n26AKK 474\r\nQJ699 307\r\nAKKAA 737\r\nKA5TK 600\r\nJ3Q33 830\r\n7Q7Q7 953\r\n82888 888\r\nKKK22 554\r\n55Q99 354\r\n52522 868\r\n9586T 844\r\nA7T95 465\r\nJ5TQ9 660\r\nK6352 487\r\n32A95 925\r\n275Q9 84\r\n555AA 964\r\n7Q247 11\r\nQ3A44 53\r\nJJ548 272\r\nJ8673 103\r\n22229 317\r\n3K566 505\r\n99AA9 826\r\n2468T 910\r\n44QQQ 605\r\nQJQ77 932\r\n25229 614\r\n666QQ 994\r\n99777 568\r\n6622J 945\r\nAK48T 243\r\nQQ676 922\r\nTKKA8 715\r\n78788 225\r\nAA7AT 240\r\n7TK6Q 886\r\nQQ877 308\r\n55559 220\r\n7K5QT 978\r\n7543T 206\r\n2K522 149\r\n229AA 975\r\nJ5955 667\r\nA8298 95\r\n4T493 189\r\n632A3 199\r\n3K43J 181\r\n6T52Q 657\r\nJ58JJ 19\r\n29KTA 173\r\nK33J6 662\r\nQ266J 633\r\n74K44 128\r\nTT996 563\r\nQJ886 280\r\n4Q82Q 287\r\n85535 601\r\nJT88A 810\r\n95355 797\r\n22J22 121\r\n4TTT4 665\r\nQ8888 496\r\n89A8A 47\r\n52885 10\r\nAT6J3 454\r\n9Q66Q 17\r\nA8AA2 651\r\n47774 299\r\nQT788 939\r\nTQQQQ 724\r\nQAT94 132\r\n5KK6K 68\r\nT4322 628\r\nK6666 174\r\n88J88 194\r\n43AAA 914\r\nT882J 338\r\n6QT66 171\r\n48Q88 1000\r\nTKTTJ 502\r\nAA372 763\r\nJKKJJ 60\r\n23232 694\r\nA355J 430\r\n36J68 148\r\n57QQQ 277\r\n9JT9T 577\r\nTQJQT 434\r\n93334 792\r\n65J75 761\r\n98894 24\r\n33833 775\r\nJ5Q2K 322\r\n56T58 476\r\n529K6 236\r\nK5KJ5 296\r\n35JQ9 951\r\nJT6T2 545\r\n63328 960\r\n484A6 716\r\nJ3T99 622\r\n47J8K 162\r\n574A9 442\r\n5JA96 702\r\n868A9 947\r\n56JQK 424\r\nTT5AA 36\r\nK2K22 125\r\nAQA4A 470\r\n252J2 814\r\nTTTT2 490\r\n22J62 428\r\n7733T 160\r\nQT3KA 200\r\n9A972 208\r\nJA46J 798\r\nA4QJ6 45\r\n9J488 557\r\nJAAAJ 188\r\n3Q5JJ 350\r\n24K24 22\r\nQ88K8 369\r\nA2AA2 131\r\nTK659 824\r\n48726 782\r\n3939J 573\r\n4Q372 525\r\nA23J7 705\r\n83A5K 807\r\n5J522 462\r\nJ935A 431\r\n99933 252\r\n97Q6T 803\r\n33J3K 293\r\n65662 909\r\n66538 896\r\n4J4JK 404\r\n76TAK 617\r\n99979 394\r\nQ3JT5 823\r\nA3K38 606\r\n2K2J3 179\r\n97AA9 530\r\n6J6QQ 8\r\n5J2T2 949\r\nA44A5 145\r\n39A2T 523\r\n6665Q 700\r\n23288 693\r\n65336 183\r\nT64T8 897\r\nK76K6 48\r\n2JTT2 146\r\nK94J8 769\r\nAA8AA 556\r\n5Q775 586\r\n5TQ8Q 143\r\nAJA8A 529\r\nA3629 153\r\n4Q69T 52\r\n53T9T 414\r\nQJ424 114\r\nJ595K 276\r\n63622 116\r\n99599 295\r\n94J9J 916\r\n42822 304\r\n5T45Q 318\r\nT999T 878\r\n777J7 669\r\n79T77 581\r\nTTAAA 921\r\nA3333 736\r\nKJ54K 88\r\nK363K 618\r\n7T837 303\r\n8833T 43\r\n2976A 227\r\nTTTT5 441\r\nJ66T4 928\r\nTT5A8 138\r\n8TQJ3 641\r\n29JT5 204\r\nK3T65 113\r\nJ9855 284\r\n3KA22 835\r\n6J644 836\r\n3K695 801\r\n58855 74\r\nQ6579 126\r\n64QK7 191\r\nATATQ 895\r\n9KK97 560\r\n32Q23 298\r\nJ98J3 336\r\n333TT 593\r\n33QQQ 438\r\n244Q2 446\r\nQJAAA 902\r\n88887 777\r\nQ8838 752\r\n86668 984\r\n924QK 288\r\nKJKJK 186\r\nT22JJ 500\r\nJ65KA 764\r\n4K559 993\r\n44646 327\r\nQ444Q 598\r\nJAA3J 741\r\nJ4J49 976\r\n5J6T5 778\r\nTTATT 908\r\nAA9T9 481\r\n38696 320\r\nT444A 594\r\nK33KT 376\r\n66955 127\r\nKAKJT 709\r\nJT8A6 184\r\nJJ8JJ 330\r\n7AAKA 684\r\n33233 373\r\n8T8K8 576\r\n8TQ27 4\r\n552K5 182\r\n5692J 21\r\nTTQJT 912\r\n6QA66 840\r\nTT3TT 546\r\n6K4Q8 849\r\nT779T 631\r\nK93K9 232\r\n6A4TA 254\r\n2K5A3 154\r\n2QQ22 491\r\nAAKK2 680\r\n63326 302\r\nTT7KQ 378\r\n7J477 105\r\nQJQ4J 862\r\nJ4596 867\r\n22335 743\r\n74329 221\r\nQ8333 758\r\n699J6 285\r\n8QAJJ 497\r\n8QT67 711\r\nKAAAA 92\r\nK96T8 548\r\n8TT9T 508\r\nT977J 516\r\n27272 313\r\nAKKK8 389\r\n879A6 18\r\n55K33 383\r\n38484 339\r\nA9299 437\r\n833A3 290\r\n77JJ4 433\r\n7JAJ2 856\r\nQK45J 540\r\nQ96T2 699\r\n88884 212\r\nK6778 205\r\nQA4TA 192\r\nQA86Q 872\r\n22T7T 972\r\n23272 415\r\n42J42 558\r\nQ72Q7 242\r\n8A45T 948\r\n4JJ4J 177\r\nJ4Q9A 323\r\nKA3KQ 937\r\nAA847 655\r\nAQJQQ 61\r\n36T6K 294\r\n63673 766\r\n7QTT8 300\r\n8KQ86 346\r\nQQJK7 321\r\nA32AA 549\r\n44KK4 357\r\n55454 547\r\n33666 260\r\nAAQQQ 436\r\nJ55K5 264\r\n3KJQ3 685\r\n99K99 269\r\n9J9QJ 677\r\nJ8844 854\r\n2567Q 176\r\nAAAJ5 689\r\nT4T9T 831\r\n36874 356\r\nTTTJT 122\r\n33993 609\r\n4JK3T 920\r\n79772 65\r\n55225 942\r\nK228K 898\r\n3K2QA 274\r\nQTAQQ 718\r\n6JJJ9 506\r\n83869 645\r\nA8T24 475\r\nA3647 625\r\n99353 158\r\n5566T 652\r\n5J454 726\r\nA6AT6 71\r\n42JJ9 286\r\n88JQ8 344\r\nAAQJK 477\r\nJ6266 876\r\n4T499 750\r\n76853 986\r\n4QKKT 603\r\n84K3K 629\r\nAA636 250\r\n3T263 756\r\nT8227 885\r\n9J533 28\r\n26446 613\r\nAAAJA 841\r\n7AA2A 305\r\nQQJQQ 503\r\nQT33T 509\r\n3TT22 379\r\n88844 78\r\n629KJ 416\r\n74J44 813\r\nQA79K 526\r\n2T6T5 522\r\nK2TQA 774\r\n85AQJ 283\r\nTJ6AQ 735\r\n335J2 450\r\nK4944 222\r\nK54K7 348\r\nKKKTK 673\r\n7K797 407\r\nJKKAK 561\r\nTJT77 663\r\nJJ777 265\r\n6QJQ3 873\r\n2QTK5 456\r\n2Q4A9 198\r\n5J7Q6 270\r\n86A67 675\r\nJ4444 534\r\n55K3T 152\r\n277KJ 55\r\n8QQ2J 838\r\nA75QA 234\r\n848JJ 553\r\nJJ28J 314\r\n7698Q 583\r\nATTTA 851\r\nQ88QQ 353\r\n89A34 955\r\nQ82K5 691\r\nT4A8J 858\r\n852J7 253\r\n39JQ8 319\r\n2Q7QQ 828\r\nQQ4KQ 848\r\n35KQT 233\r\n4AAAA 952\r\nK289K 695\r\n49T88 541\r\n6QJ44 544\r\nK4KAK 408\r\n75882 435\r\n9K99K 515\r\n3TK3J 608\r\n94222 564\r\nA9K44 666\r\n3722T 391\r\n8J88J 742\r\nQ2KQK 950\r\nJ999Q 493\r\n85K88 331\r\nJ4AAA 935\r\nAJTAT 144\r\n796J9 776\r\n42444 788\r\n52K9K 980\r\n9QQ97 597\r\nKQQQQ 793\r\nK8267 884\r\n8Q594 90\r\n8J829 860\r\n3KT64 245\r\n6JTQ6 85\r\nAJ28T 349\r\n995TT 733\r\n33444 659\r\n5J333 927\r\n32JA6 335\r\n38Q65 619\r\n96966 626\r\n55JJ5 815\r\n3664T 940\r\nAAAK6 362\r\n62573 772\r\nTAAA9 588\r\nA9K63 34\r\n4753Q 209\r\n59595 913\r\n57755 42\r\n2J922 315\r\nA6834 273\r\nQAQ8Q 239\r\n3K6QQ 94\r\nA55J5 729\r\n66776 89\r\nAT525 479\r\n66663 616\r\nA4A5A 207\r\n88TQT 551\r\n87Q5T 749\r\n77KKK 291\r\nT3T44 855\r\n5927A 621\r\nA28T6 187\r\nQT7Q9 135\r\n77J79 786\r\n8JT88 571\r\n82J28 13\r\n333J6 519\r\n67229 790\r\nT577T 390\r\n62226 762\r\nT8888 713\r\n7JQJQ 877\r\n532AA 384\r\n5A5AJ 533\r\n66JA6 381\r\n36KK9 457\r\n43343 755\r\n67767 35\r\n96AJ3 398\r\nJJA95 380\r\n2QQ8Q 569\r\n69AK9 567\r\n9KK9T 654\r\n84244 958\r\nKTJKK 32\r\nK87Q5 180\r\nT9A26 262\r\nQ555Q 787\r\n48J6Q 67\r\nK4KKK 638\r\nTAAAA 686\r\n33335 962\r\n88886 696\r\n2334Q 439\r\n7T78K 364\r\n73377 54\r\n8Q744 998\r\n52Q49 707\r\nJ3J5J 370\r\nK2KJ2 482\r\nT6JK5 969\r\n53J5J 371\r\nQQQA2 983\r\n8Q886 93\r\n63888 818\r\nTQQQK 746\r\n7285A 578\r\n66656 123\r\nQ9AQQ 809\r\n47AA7 730\r\n479Q2 731\r\n55335 869\r\n3K3QK 166\r\n6K257 228\r\n2JQ64 139\r\n26J4K 624\r\n55Q55 866\r\nKQ937 697\r\nTJ783 39\r\n72T5K 247\r\n444K4 432\r\nJ2783 723\r\nT68T6 817\r\nTT5T9 420\r\nT9432 426\r\n6AAK5 903\r\n33732 630\r\nQA4A4 683\r\n6JJ6A 115\r\nKJK3T 698\r\n88783 520\r\n2A8AT 847\r\n3A83A 449\r\n4Q4J9 324\r\nTQTQQ 938\r\n693QA 218\r\n398A8 310\r\n94Q68 129\r\n9J899 535\r\n75A55 562\r\n5KKKK 56\r\nTA376 480\r\nJJ5J5 565\r\n6J7KJ 770\r\n86667 892\r\n6686J 14\r\n89889 780\r\n65555 585\r\nQQQJJ 688\r\n88JJ2 492\r\n33238 812\r\n7862T 753\r\nJ22J2 587\r\n73747 973\r\nK3JQA 2\r\nK3K9K 150\r\n6A8JA 9\r\nT5K8A 670\r\n5K33T 555\r\nK2266 528\r\nJAK59 784\r\n8AQ74 213\r\n6QA9T 570\r\n27873 69\r\n27TQT 507\r\n8K3QA 75\r\n6T252 226\r\nT4432 46\r\nJQQ6Q 779\r\nKKAQK 443\r\n96869 83\r\n3JQ3A 326\r\nQ222K 875\r\nA3954 244\r\n333JJ 406\r\n22AQQ 959\r\n55585 754\r\nJT938 981\r\n555J5 418\r\nTJJT9 773\r\nJ826A 863\r\n3828J 316\r\n5A8JJ 7\r\n47K83 536\r\nK5J9K 325\r\nT4Q59 382\r\nKKK7K 402\r\n75758 297\r\n74484 829\r\n7T47T 278\r\nK744Q 237\r\nT8T5J 147\r\n55228 880\r\nJ57J2 172\r\n57549 592\r\n76276 422\r\n936JQ 483\r\nQQ5QJ 255\r\nA7T78 783\r\n5TT58 971\r\nJJJJJ 86\r\n55QQQ 692\r\nT728T 701\r\nKTTKT 372\r\nTT7TT 282\r\nQ5982 604\r\nKK8KK 514\r\n8KKTK 448\r\n6K8J7 118\r\n499J9 87\r\n22828 140\r\n58JJ8 789\r\n66637 58\r\n44445 919\r\nJKJ63 890\r\nA463A 918\r\n393J8 827\r\n44434 37\r\n999T7 999\r\n966J7 802\r\n43962 51\r\nK5J45 719\r\n87KK5 757\r\n2K337 977\r\n582J9 627\r\n69639 355\r\n97KJ6 610\r\nJ2223 704\r\n6A4T5 165\r\n7AJA7 767\r\n646K4 706\r\nQQ2QJ 72\r\nT3JK8 301\r\n6T3AK 661\r\n7K8T5 970\r\nJJ33J 396\r\n49446 412\r\nAA77A 649\r\n66A86 64\r\nQQAQQ 120\r\n8AA8A 968\r\n57QJ2 579\r\nKK99K 930\r\n94499 864\r\n7K7Q7 275\r\n88A88 210\r\n37837 458\r\nA447A 931\r\nAAA66 643\r\n66667 887\r\n733A8 819\r\n3792Q 602\r\nJ4532 41\r\n6869Q 611\r\nKJQKQ 894\r\nAJQ87 38\r\n39A74 941\r\n282JJ 345\r\n88Q73 251\r\n77595 256\r\n22777 124\r\n94299 358\r\nTTTT4 489\r\nQQJ44 825\r\n58K24 466\r\n92AA9 111\r\n6368T 27\r\n8JT75 405\r\n876K3 607\r\n2A8Q7 361\r\n9QAK5 923\r\nJ666J 312\r\nA9Q74 155\r\n32242 202\r\n999A5 559\r\n77772 427\r\n2QJJQ 333\r\nQ222T 157\r\n3QQQJ 366\r\nJ6225 401\r\n33334 440\r\n443K6 268\r\n25Q73 352\r\n56565 879\r\n84TAQ 387\r\n79777 861\r\n666AT 811\r\n7A97A 235\r\n2K6KJ 859\r\n9J993 281\r\nQ8TK9 808\r\n56429 98\r\n3JJT6 77\r\n22383 905\r\n5A683 907\r\n8KJKK 267\r\n33T38 168\r\n5865K 615\r\n6QQQ3 399\r\n5AQ82 340\r\nQK7QK 720\r\n74474 347\r\nJ5693 589\r\nJAAQ9 623\r\n22267 417\r\n8T88Q 29\r\nJ2422 527\r\n6A5AA 110\r\n23J33 612\r\n2Q997 289\r\n5T564 967\r\nKQ52Q 214\r\n9J53T 175\r\n6TT76 982\r\n44QKQ 201\r\n32633 911\r\nKAAJK 634\r\n75J57 49\r\n66668 901\r\n6QJK6 494\r\nJ9K66 12\r\nJKK6K 5\r\nJ3869 82\r\nQQ7QQ 740\r\nKKK46 934\r\n56646 367\r\nQ5433 486\r\n88636 954\r\nJ8277 100\r\nK5566 343\r\n666A6 190\r\nKKJKK 375\r\n3J322 259\r\n3K9J4 360\r\n888A6 584\r\n66865 708\r\nT2JQ2 722\r\nJJ393 632\r\n77TT7 834\r\n22Q82 57\r\n97AJA 785\r\nQQ9QQ 501\r\n6AA6K 580\r\n53353 956\r\nJ8JKQ 6\r\nQAA7T 671\r\nA3T5K 891\r\n4QKJJ 795\r\n5T333 91\r\n887A8 997\r\n5K57J 796\r\nAQ763 595\r\nQT777 995\r\n29J45 996\r\n76262 130\r\n696K9 961\r\n6A65K 197\r\n34838 512\r\n4299K 193\r\nK3J37 985\r\n9922A 881\r\n5TT8T 134\r\n44Q45 504\r\n438K8 133\r\nJA788 459\r\nKKAAK 900\r\n44222 445\r\n8TJTK 468\r\n6664K 337\r\n28JK3 850\r\nTJ44J 832\r\n57932 957\r\nT2AJ4 409\r\nTA596 635\r\n87839 23\r\nA2722 248\r\nK7777 543\r\n638T9 966\r\n55A32 471\r\n69JJ3 893\r\n253KK 676\r\nQ8Q3T 63\r\nJ4K7K 712\r\n9999A 20\r\n868KK 257\r\n27354 266\r\n75K75 687\r\nAAAAQ 400\r\n5252Q 169\r\n2TT62 517\r\n34J4J 974\r\nTAQ99 112\r\n58J6T 452\r\n82T58 392\r\n65J62 732\r\n5T445 263\r\nAKATA 640\r\nQJT55 329\r\nT4449 342\r\nA567A 647\r\nA2T36 833\r\nJ742T 799\r\nKA64T 395\r\nQ4257 989\r\n99993 223\r\nTJTT9 425\r\n8KAKQ 648\r\n2J4K5 842\r\n43J34 151\r\n9Q949 636\r\nKK4K4 229\r\n7757T 385\r\n4J774 421\r\n9QKAQ 79\r\n469TA 965\r\nK63J9 164\r\n3AT43 874\r\n4JKQ6 664\r\n373Q3 791\r\nKK66Q 377\r\n77JQ7 596\r\n8JAA8 658\r\nTJT3T 447\r\nA5555 119\r\n8486J 768\r\n58289 904\r\n9T999 642\r\n44JK4 472\r\nA752Q 672\r\n36TA8 906\r\n84824 403";
            string[] handList = puzzleInput.Split("\r\n");

            Part1(handList);
            Part2(handList);
        }
    }
}