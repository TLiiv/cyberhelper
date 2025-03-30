import React, { useState } from "react";
import {
  Box,
  Button,
  Flex,
  Input,
  Text,
  Image,
  VStack,
  HStack,
  Heading,
} from "@chakra-ui/react";

const ScamPolitseiIdLogin = () => {
  const [selectedMethod, setSelectedMethod] = useState("id-kaart");

  return (
    <Box bg="gray.100" minH="100vh" display="flex" flexDirection="column">
      <Flex bg="#003168" p={3} align="center" color="gray.100" justify="center">
        <Box width="55%">
          <HStack justify="space-between" fontWeight="semibold" fontSize="lg">
            <Text fontSize="xl" ml={4}>
              Turvaline autentimine asutuste e-teenustes
            </Text>

            <HStack mr={12}>
              <Text
                _hover={{ cursor: "pointer", textDecoration: "underline" }}
                pr={2}
              >
                LIGIPÄÄSETAVUS
              </Text>
              <Box
                height="38px"
                borderLeft="1px solid white"
                mx={2}
                as="span"
              />
              <Text
                _hover={{ cursor: "pointer", textDecoration: "underline" }}
                pl={2}
              >
                ENGLISH
              </Text>
              <Text
                _hover={{ cursor: "pointer", textDecoration: "underline" }}
                pl={2}
              >
                РУССКИЙ
              </Text>
            </HStack>
          </HStack>
        </Box>
      </Flex>

      <Flex bg="white" p={6} justify="center">
        <Box width="55%">
          <Image
            src="https://tara.ria.ee/assets/tara-logo.png"
            w="277px"
            ml={2}
          />
        </Box>
      </Flex>

      <Box p={6} mx="auto" width="55%" borderRadius="md">
        <Flex>
          <HStack mb={4}>
            <Button
              width="50%"
              fontWeight="semibold"
              textStyle="xl"
              rounded="lg"
              size="lg"
              bg={selectedMethod === "id-kaart" ? "#005f87" : "white"}
              color={selectedMethod === "id-kaart" ? "white" : "#003168"}
              onClick={() => setSelectedMethod("id-kaart")}
              _hover={{
                bg: "#005f87",
                color: "white",
              }}
            >
              ID-kaart
            </Button>
            <Button
              width="50%"
              fontWeight="semibold"
              textStyle="xl"
              rounded="lg"
              size="lg"
              bg={selectedMethod === "mobiil-id" ? "#005f87" : "white"}
              color={selectedMethod === "mobiil-id" ? "white" : "#003168"}
              onClick={() => setSelectedMethod("mobiil-id")}
              _hover={{
                bg: "#005f87",
                color: "white",
              }}
            >
              Mobiil-ID
            </Button>
            <Button
              width="50%"
              fontWeight="semibold"
              textStyle="xl"
              rounded="lg"
              size="lg"
              bg={selectedMethod === "smart-id" ? "#005f87" : "white"}
              color={selectedMethod === "smart-id" ? "white" : "#003168"}
              onClick={() => setSelectedMethod("smart-id")}
              _hover={{
                bg: "#005f87",
                color: "white",
              }}
            >
              Smart-ID
            </Button>
          </HStack>
        </Flex>

        <Flex bg="white" p={6} justify="flex-end" borderRadius="lg">
          <Flex width="85%" mb={4}>
            {selectedMethod === "id-kaart" && (
              <VStack align="start">
                <Heading color="#003168" size="3xl" fontWeight="medium" mt={3}>
                  ID-Kaart
                </Heading>
                <Text fontSize="lg" fontWeight="normal" mt={4}>
                  Teenusesse
                  <b> PPA ID-kaardi ja passi taotlemise iseteenindus </b>
                  sisselogimiseks vajate kaardilugejat ja kehtivat ID-kaarti.
                  Sisestage ID-kaart kaardilugejasse ja vajutage "Jätka".
                </Text>
                <Button
                  bg="#008936"
                  _hover={{ bg: "#00702c" }}
                  width="14%"
                  fontWeight="normal"
                  textStyle="xl"
                  rounded="lg"
                  mt={4}
                  pt={6}
                  pb={6}
                >
                  Jätka
                </Button>
              </VStack>
            )}

            {selectedMethod === "mobiil-id" && (
              <VStack align="start">
                <Heading color="#003168" size="3xl" fontWeight="medium" mt={3}>
                  Mobiil-ID
                </Heading>
                <Text fontSize="lg" fontWeight="normal" mt={4}>
                  Teenusesse
                  <b> PPA ID-kaardi ja passi taotlemise iseteenindus </b>
                  sisselogimiseks vajate kehtivat Mobiil-ID lepingut. Sisestage
                  oma isikukood ja telefoninumber ning vajutage "Jätka".
                </Text>
                <Input placeholder="Isikukood" />
                <Input placeholder="Telefoninumber" />
                <Button
                  bg="#008936"
                  _hover={{ bg: "#00702c" }}
                  width="14%"
                  fontWeight="normal"
                  textStyle="xl"
                  rounded="lg"
                  mt={4}
                  pt={6}
                  pb={6}
                >
                  Jätka
                </Button>
              </VStack>
            )}

            {selectedMethod === "smart-id" && (
              <VStack align="start">
                <Heading color="#003168" size="3xl" fontWeight="medium" mt={3}>
                  Smart-ID
                </Heading>
                <Text fontSize="lg" fontWeight="normal" mt={4}>
                  Teenusesse PPA ID-kaardi ja passi taotlemise iseteenindus
                  sisselogimiseks vajate kehtivat Smart-ID kontot. Sisestage oma
                  isikukood ning vajutage "Jätka".
                </Text>
                <Input placeholder="Isikukood" />
                <Button
                  bg="#008936"
                  _hover={{ bg: "#00702c" }}
                  width="14%"
                  fontWeight="normal"
                  textStyle="xl"
                  rounded="lg"
                  mt={4}
                  pt={6}
                  pb={6}
                >
                  Jätka
                </Button>
              </VStack>
            )}
          </Flex>
        </Flex>
      </Box>

      <Flex
        bg="#dbdfe2"
        p={4}
        justify="center"
        align="center"
        width="100%"
        mt="auto"
      >
        <Box width="55%">
          <Image
            src="https://tara.ria.ee/assets/el_regionaalarengu_fond_horisontaalne.jpg"
            alt="Footer Image"
            width="130px"
            m={3}
          />
        </Box>
      </Flex>
    </Box>
  );
};

export default ScamPolitseiIdLogin;
