using CatFacts.Models;
using Microsoft.EntityFrameworkCore;

namespace CatFacts.Data.Seed;

public static class CatFactSeedData{
    public static void Seed(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CatFact>().HasData(
                    
            new CatFact { 
                Id = 1, 
                Fact = "A cat's nose is as unique as a human's fingerprint.", 
                Length = 51, 
                CreatedAt = new DateTime(2026, 9, 7, 15, 50, 48) 
            },
            new CatFact { 
                Id = 2, 
                Fact = "A cat will tremble or shiver when it is in extreme pain.", 
                Length = 56, 
                CreatedAt = new DateTime(2026, 9, 7, 15, 50, 50) 
            },
            new CatFact { 
                Id = 3, 
                Fact = "Cats have 3 eyelids.", 
                Length = 20, 
                CreatedAt = new DateTime(2026, 9, 7, 15, 50, 51) 
            },
            new CatFact { 
                Id = 4, 
                Fact = "In 1987 cats overtook dogs as the number one pet in America.", 
                Length = 60, 
                CreatedAt = new DateTime(2026, 9, 7, 15, 50, 52) 
            },
            new CatFact { 
                Id = 5, 
                Fact = "The Egyptian Mau is probably the oldest breed of cat. In fact, the breed is so ancient that its name is the Egyptian word for “cat.”", 
                Length = 132, 
                CreatedAt = new DateTime(2026, 9, 7, 15, 50, 53) 
            },
            new CatFact { 
                Id = 6, 
                Fact = "In Siam, the cat was so revered that one rode in a chariot at the head of a parade celebrating the new king.", 
                Length = 108, 
                CreatedAt = new DateTime(2026, 9, 7, 16, 38, 15) 
            },
            new CatFact { 
                Id = 7, 
                Fact = "A cat's nose is as unique as a human's fingerprint.", 
                Length = 51, 
                CreatedAt = new DateTime(2026, 9, 7, 16, 41, 31) 
            },
            new CatFact { 
                Id = 8, 
                Fact = "A tomcat (male cat) can begin mating when he is between 7 and 10 months old.", 
                Length = 76, 
                CreatedAt = new DateTime(2026, 9, 7, 16, 42, 9) }
            ,
            new CatFact { 
                Id = 9, 
                Fact = "The strongest climber among the big cats, a leopard can carry prey twice its weight up a tree.", 
                Length = 94, 
                CreatedAt = new DateTime(2026, 9, 7, 16, 50, 57) 
            },
            new CatFact { 
                Id = 10,
                Fact = "Cats, especially older cats, do get cancer. Many times this disease can be treated successfully.", 
                Length = 96, 
                CreatedAt = new DateTime(2026, 9, 7, 16, 58, 20) 
            },
            new CatFact { 
                Id = 11,
                Fact = "The average lifespan of an outdoor-only (feral and non-feral) is about 3 years; an indoor-only cat can live 16 years and longer. Some cats have been documented to have a longevity of 34 years.", 
                Length = 192, 
                CreatedAt = new DateTime(2026, 9, 7, 17, 26, 11) 
            },
            new CatFact { 
                Id = 12,
                Fact = "The Maine Coone is the only native American long haired breed.", 
                Length = 62, 
                CreatedAt = new DateTime(2026, 9, 7, 17, 26, 12) 
            },
            new CatFact { 
                Id = 13,
                Fact = "Cats spend nearly 1/3 of their waking hours cleaning themselves.", 
                Length = 64, 
                CreatedAt = new DateTime(2026, 9, 7, 17, 26, 13) 
            },
            new CatFact { 
                Id = 14,
                Fact = "It has been scientifically proven that owning cats is good for our health and can decrease the occurrence of high blood pressure and other illnesses.", 
                Length = 149, 
                CreatedAt = new DateTime(2026, 9, 7, 17, 26, 14) 
            },
            new CatFact { 
                Id = 15,
                Fact = "Cats can judge within 3 inches the precise location of a sound being made 1 yard away.", 
                Length = 86, 
                CreatedAt = new DateTime(2026, 9, 7, 17, 26, 15) 
            },
            new CatFact { 
                Id = 16,
                Fact = "A cat can spend five or more hours a day grooming himself.", 
                Length = 58, 
                CreatedAt = new DateTime(2026, 9, 7, 17, 26, 15) 
            },
            new CatFact { 
                Id = 17,
                Fact = "When your cats rubs up against you, she is actually marking you as 'hers' with her scent. If your cat pushes his face against your head, it is a sign of acceptance and affection.", 
                Length = 137, 
                CreatedAt = new DateTime(2026, 9, 7, 17, 26, 17) 
            },
            new CatFact { 
                Id = 18,
                Fact = "Ailurophile is the word cat lovers are officially called.", 
                Length = 57, 
                CreatedAt = new DateTime(2026, 9, 7, 17, 26, 18) 
            },
            new CatFact { 
                Id = 19,
                 Fact = "Cats have the largest eyes of any mammal.", 
                Length = 41, 
                CreatedAt = new DateTime(2026, 9, 7, 17, 26, 19) 
            },
            new CatFact { 
                Id = 20,
                 Fact = "Cats have the largest eyes of any mammal.", 
                Length = 41, 
                CreatedAt = new DateTime(2026, 9, 7, 17, 26, 20) 
            },
            new CatFact { 
                Id = 21,
                 Fact = "The heaviest cat on record is Himmy, a Tabby from Queensland, Australia. He weighed nearly 47 pounds (21 kg). He died at the age of 10.", 
                Length = 135, 
                CreatedAt = new DateTime(2026, 9, 7, 17, 26, 21) 
            },
            new CatFact { 
                Id = 22,
                 Fact = "In Ancient Egypt, when a person's house cat passed away, the owner would shave their eyebrows to reflect their grief.", 
                Length = 117, 
                CreatedAt = new DateTime(2026, 9, 7, 17, 26, 22) 
            },
            new CatFact { 
                Id = 23,
                Fact = "Unlike humans, cats cannot detect sweetness which likely explains why they are not drawn to it at all.", 
                Length = 102, 
                CreatedAt = new DateTime(2026, 9, 7, 17, 26, 23) 
            },
            new CatFact { 
                Id = 24,
                Fact = "Cats sleep 16 to 18 hours per day. When cats are asleep, they are still alert to incoming stimuli. If you poke the tail of a sleeping cat, it will respond accordingly.", 
                Length = 167, 
                CreatedAt = new DateTime(2026, 9, 7, 17, 26, 24) 
            },
            new CatFact { 
                Id = 25,
                Fact = "A cat almost never meows at another cat, mostly just humans. Cats typically will spit, purr, and hiss at other cats.", 
                Length = 116, 
                CreatedAt = new DateTime(2026, 9, 7, 17, 26, 25) 
            },
            new CatFact { 
                Id = 26,
                Fact = "A cat's nose is as unique as a human's fingerprint.", 
                Length = 51, 
                CreatedAt = new DateTime(2026, 9, 7, 17, 26, 26) 
            },
            new CatFact { 
                Id = 27,
                Fact = "While many cats enjoy milk, it will give some cats diarrhea.", 
                Length = 60, 
                CreatedAt = new DateTime(2026, 9, 7, 17, 26, 27) 
            },
            new CatFact { 
                Id = 28,
                Fact = "Statistics indicate that animal lovers in recent years have shown a preference for cats over dogs!", 
                Length = 98, 
                CreatedAt = new DateTime(2026, 9, 7, 17, 26, 27) 
            },
            new CatFact { 
                Id = 29,
                Fact = "The strongest climber among the big cats, a leopard can carry prey twice its weight up a tree.", 
                Length = 94, 
                CreatedAt = new DateTime(2026, 9, 7, 17, 26, 28) 
            },
            new CatFact { 
                Id = 30,
                Fact = "Cats are subject to gum disease and to dental caries. They should have their teeth cleaned by the vet or the cat dentist once a year.", 
                Length = 133, 
                CreatedAt = new DateTime(2026, 9, 7, 17, 26, 30) 
            }
        );
    }
}
