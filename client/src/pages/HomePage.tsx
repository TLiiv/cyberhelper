import { Link as RouterLink } from "react-router-dom";
import { Box, Heading, Button, VStack, Text, Highlight } from "@chakra-ui/react";


const HomePage: React.FC = () => {

  return (
    <>
      <Box maxW="1200px" mx="auto" mt={10} p={8} borderRadius="lg">
        <VStack align="stretch">
          <Heading
            as="h1"
            fontSize={{ base: "4xl", md: "5xl" }}
            textAlign="center"
            fontWeight="bold"
            lineHeight="1.2"
            letterSpacing="tight"
          >
            <Text
              display={{ base: "inline", md: "block" }}
            >
              <Highlight query="sina" styles={{ color: "teal.500" }}>
                Kas sina suudad ära tuvastada
              </Highlight>
            </Text>
            <Text
              display={{ base: "inline", md: "block" }}
            >
              <Highlight query="andmepüügist" styles={{ color: "teal.500" }}>
                andmepüügi rünnaku?
              </Highlight>
            </Text>
          </Heading>

          <Text fontSize="xl" textAlign="center">
            Selle veebilehe peamine eesmärk on suurendada inimeste teadlikkust andmepüügist, mis on üks kõige levinum küberkuriteo vorm.
          </Text>
        </VStack>
      </Box>

      <Box maxW="900px" mx="auto" mt={10} p={8} borderRadius="lg" shadow="xl">
        <VStack align="stretch">
          <Text fontSize="lg" >
            Andmepüük (phishing) on petuskeem, kus ründajad üritavad meelitada inimesi jagama tundlikut
            informatsiooni, nagu paroolid, krediitkaardiandmed ja muud isiklikud andmed. Petturid maskeerivad
            end usaldusväärseteks allikateks, kasutades selleks e-kirju, võltsitud veebilehti või reaalajas toimuvaid tekstilisi sõnumeid.
          </Text>

          <Text fontSize="lg" >
            Kas tead kuidas andmepüüki ära tunda? Testi oma teadmisi ja uuri, kas sa suudad
            eristada ehtsa e-kirja petu e-kirjast.
          </Text>

          <Text>Allikad WIKIPEDIA PHISING + Kui palju näiteks eelmisel aastal oli rünnakuid</Text>
          <RouterLink to={"/test"}>
            <Heading>Tee test ja uuri, kas tunned õngitsuskirja ära!</Heading>
            <Button textStyle="lg" colorPalette="gray"><Text fontWeight="semibold" color="teal.500">Testile</Text></Button>

          </RouterLink>
        </VStack>
      </Box >
    </>
  );
};

export default HomePage;
