using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CatFacts.Migrations
{
    /// <inheritdoc />
    public partial class AddCatFactSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "CatFacts",
                columns: new[] { "Id", "CreatedAt", "Fact", "Length" },
                values: new object[,]
                {
                    { 1, new DateTime(2026, 9, 7, 15, 50, 48, 0, DateTimeKind.Unspecified), "A cat's nose is as unique as a human's fingerprint.", 51 },
                    { 2, new DateTime(2026, 9, 7, 15, 50, 50, 0, DateTimeKind.Unspecified), "A cat will tremble or shiver when it is in extreme pain.", 56 },
                    { 3, new DateTime(2026, 9, 7, 15, 50, 51, 0, DateTimeKind.Unspecified), "Cats have 3 eyelids.", 20 },
                    { 4, new DateTime(2026, 9, 7, 15, 50, 52, 0, DateTimeKind.Unspecified), "In 1987 cats overtook dogs as the number one pet in America.", 60 },
                    { 5, new DateTime(2026, 9, 7, 15, 50, 53, 0, DateTimeKind.Unspecified), "The Egyptian Mau is probably the oldest breed of cat. In fact, the breed is so ancient that its name is the Egyptian word for “cat.”", 132 },
                    { 6, new DateTime(2026, 9, 7, 16, 38, 15, 0, DateTimeKind.Unspecified), "In Siam, the cat was so revered that one rode in a chariot at the head of a parade celebrating the new king.", 108 },
                    { 7, new DateTime(2026, 9, 7, 16, 41, 31, 0, DateTimeKind.Unspecified), "A cat's nose is as unique as a human's fingerprint.", 51 },
                    { 8, new DateTime(2026, 9, 7, 16, 42, 9, 0, DateTimeKind.Unspecified), "A tomcat (male cat) can begin mating when he is between 7 and 10 months old.", 76 },
                    { 9, new DateTime(2026, 9, 7, 16, 50, 57, 0, DateTimeKind.Unspecified), "The strongest climber among the big cats, a leopard can carry prey twice its weight up a tree.", 94 },
                    { 10, new DateTime(2026, 9, 7, 16, 58, 20, 0, DateTimeKind.Unspecified), "Cats, especially older cats, do get cancer. Many times this disease can be treated successfully.", 96 },
                    { 11, new DateTime(2026, 9, 7, 17, 26, 11, 0, DateTimeKind.Unspecified), "The average lifespan of an outdoor-only (feral and non-feral) is about 3 years; an indoor-only cat can live 16 years and longer. Some cats have been documented to have a longevity of 34 years.", 192 },
                    { 12, new DateTime(2026, 9, 7, 17, 26, 12, 0, DateTimeKind.Unspecified), "The Maine Coone is the only native American long haired breed.", 62 },
                    { 13, new DateTime(2026, 9, 7, 17, 26, 13, 0, DateTimeKind.Unspecified), "Cats spend nearly 1/3 of their waking hours cleaning themselves.", 64 },
                    { 14, new DateTime(2026, 9, 7, 17, 26, 14, 0, DateTimeKind.Unspecified), "It has been scientifically proven that owning cats is good for our health and can decrease the occurrence of high blood pressure and other illnesses.", 149 },
                    { 15, new DateTime(2026, 9, 7, 17, 26, 15, 0, DateTimeKind.Unspecified), "Cats can judge within 3 inches the precise location of a sound being made 1 yard away.", 86 },
                    { 16, new DateTime(2026, 9, 7, 17, 26, 15, 0, DateTimeKind.Unspecified), "A cat can spend five or more hours a day grooming himself.", 58 },
                    { 17, new DateTime(2026, 9, 7, 17, 26, 17, 0, DateTimeKind.Unspecified), "When your cats rubs up against you, she is actually marking you as 'hers' with her scent. If your cat pushes his face against your head, it is a sign of acceptance and affection.", 137 },
                    { 18, new DateTime(2026, 9, 7, 17, 26, 18, 0, DateTimeKind.Unspecified), "Ailurophile is the word cat lovers are officially called.", 57 },
                    { 19, new DateTime(2026, 9, 7, 17, 26, 19, 0, DateTimeKind.Unspecified), "Cats have the largest eyes of any mammal.", 41 },
                    { 20, new DateTime(2026, 9, 7, 17, 26, 20, 0, DateTimeKind.Unspecified), "Cats have the largest eyes of any mammal.", 41 },
                    { 21, new DateTime(2026, 9, 7, 17, 26, 21, 0, DateTimeKind.Unspecified), "The heaviest cat on record is Himmy, a Tabby from Queensland, Australia. He weighed nearly 47 pounds (21 kg). He died at the age of 10.", 135 },
                    { 22, new DateTime(2026, 9, 7, 17, 26, 22, 0, DateTimeKind.Unspecified), "In Ancient Egypt, when a person's house cat passed away, the owner would shave their eyebrows to reflect their grief.", 117 },
                    { 23, new DateTime(2026, 9, 7, 17, 26, 23, 0, DateTimeKind.Unspecified), "Unlike humans, cats cannot detect sweetness which likely explains why they are not drawn to it at all.", 102 },
                    { 24, new DateTime(2026, 9, 7, 17, 26, 24, 0, DateTimeKind.Unspecified), "Cats sleep 16 to 18 hours per day. When cats are asleep, they are still alert to incoming stimuli. If you poke the tail of a sleeping cat, it will respond accordingly.", 167 },
                    { 25, new DateTime(2026, 9, 7, 17, 26, 25, 0, DateTimeKind.Unspecified), "A cat almost never meows at another cat, mostly just humans. Cats typically will spit, purr, and hiss at other cats.", 116 },
                    { 26, new DateTime(2026, 9, 7, 17, 26, 26, 0, DateTimeKind.Unspecified), "A cat's nose is as unique as a human's fingerprint.", 51 },
                    { 27, new DateTime(2026, 9, 7, 17, 26, 27, 0, DateTimeKind.Unspecified), "While many cats enjoy milk, it will give some cats diarrhea.", 60 },
                    { 28, new DateTime(2026, 9, 7, 17, 26, 27, 0, DateTimeKind.Unspecified), "Statistics indicate that animal lovers in recent years have shown a preference for cats over dogs!", 98 },
                    { 29, new DateTime(2026, 9, 7, 17, 26, 28, 0, DateTimeKind.Unspecified), "The strongest climber among the big cats, a leopard can carry prey twice its weight up a tree.", 94 },
                    { 30, new DateTime(2026, 9, 7, 17, 26, 30, 0, DateTimeKind.Unspecified), "Cats are subject to gum disease and to dental caries. They should have their teeth cleaned by the vet or the cat dentist once a year.", 133 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CatFacts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CatFacts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CatFacts",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CatFacts",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "CatFacts",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "CatFacts",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "CatFacts",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "CatFacts",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "CatFacts",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "CatFacts",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "CatFacts",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "CatFacts",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "CatFacts",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "CatFacts",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "CatFacts",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "CatFacts",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "CatFacts",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "CatFacts",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "CatFacts",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "CatFacts",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "CatFacts",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "CatFacts",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "CatFacts",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "CatFacts",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "CatFacts",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "CatFacts",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "CatFacts",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "CatFacts",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "CatFacts",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "CatFacts",
                keyColumn: "Id",
                keyValue: 30);
        }
    }
}
